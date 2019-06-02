package fi.aalto.demonstrator.client;

import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.ServerSocket;
import java.net.SocketException;
import java.util.Locale;

import org.opcfoundation.ua.builtintypes.LocalizedText;
import org.opcfoundation.ua.builtintypes.NodeId;
import org.opcfoundation.ua.core.BrowseDescription;
import org.opcfoundation.ua.core.BrowseDirection;
import org.opcfoundation.ua.core.BrowseResult;
import org.opcfoundation.ua.core.BrowseResultMask;
import org.opcfoundation.ua.core.Identifiers;
import org.opcfoundation.ua.core.NodeClass;
import org.opcfoundation.ua.core.ObjectNode;
import org.opcfoundation.ua.core.ReferenceDescription;
import org.opcfoundation.ua.core.VariableNode;
import org.opcfoundation.ua.core.VariableTypeNode;

import com.prosysopc.ua.StatusException;
import com.prosysopc.ua.client.AddressSpace;
import com.prosysopc.ua.nodes.UaNode;
import com.prosysopc.ua.nodes.UaObjectType;
import com.prosysopc.ua.nodes.UaReference;
import com.prosysopc.ua.nodes.UaType;
import com.prosysopc.ua.server.BrowsePath;
import com.prosysopc.ua.server.NodeManagerUaNode;
import com.prosysopc.ua.server.UaServer;
import com.prosysopc.ua.server.nodes.PlainVariable;
import com.prosysopc.ua.server.nodes.UaObjectNode;
import com.prosysopc.ua.types.di.DeviceType;
import com.prosysopc.ua.types.di.UIElementType;
import com.prosysopc.ua.types.opcua.FolderType;
import com.prosysopc.ua.types.opcua.MultiStateDiscreteType;
import com.prosysopc.ua.types.opcua.MultiStateValueDiscreteType;
import com.prosysopc.ua.types.opcua.TwoStateDiscreteType;
import com.prosysopc.ua.types.plc.server.CtrlTaskTypeNode;
import com.sun.org.apache.xpath.internal.operations.Variable;

import fi.aalto.demonstrator.server.DemonstratorServer;

//Settings for the TCP/IO Function block in nxtSTUDIO
//'UDP:10011;127.0.0.1:6785'
// Receives message from nxtSTUDIO and handles actions required 
// Implemented messages initi,inito,update
//TODO req

  
// Server class 
public class DemonstratorClient extends Thread{ 
	public static int cont;
	private DatagramSocket Socket;
	private byte[] buf = new byte[256];
	private boolean running;
	
    public void run(UaServer server, NodeManagerUaNode demoNodeManager) throws StatusException{ 
    	try {
			Socket = new DatagramSocket(6785);
		} catch (SocketException e) {
			Socket.close();
			e.printStackTrace();
		}
    	running = true;
    	System.out.println("Client running");
    	while (running) {
    		DatagramPacket packet = new DatagramPacket(buf, buf.length);
          try {
			Socket.receive(packet);
		} catch (IOException e) {
			Socket.close();
			e.printStackTrace();
		}
          InetAddress address = packet.getAddress();
          int port = packet.getPort();
          packet = new DatagramPacket(buf, buf.length, address, port);
          String received = new String(packet.getData(), 0, packet.getLength());
          System.out.printf("%s%s %n","Received: ", received);
          
          //Stop the server
          if (received.substring(0, 3).equals("end")) {
              running = false;
          }
          
          //Initialization initi;Device_name;Service1:Service2:Service3;Own_position;Connection_1:Connection_2;%Event1:Event2;Data1:Data2;
          //Initialize Hardware with state machine and location data and software_logic with input events and data
          //Own_position must be assigned all other fields can be left empty but all separators must be included in message
          if (received.substring(0, 5).equals("initi")) {
        	  int ns = demoNodeManager.getNamespaceIndex();
        	  UaNode folder = server.getAddressSpace().findNode(new NodeId(ns, "Hardware"));
        	  int start = received.indexOf(";")+1;
        	  int length = received.substring(start).indexOf(";");
        	  String name = received.substring(start, start+length);
        	  //Debugging System.out.printf("%s%s %n","Creating node ", name);
        	  DeviceType node = createDeviceType(name,folder,demoNodeManager);
        	  createState(name+"_state",node,demoNodeManager);
        	  start = start+length+1;
        	  length = received.substring(start).indexOf(";");
        	  String events = received.substring(start, start+length);
        	  int ev = createEvents(events, node, demoNodeManager,name);
        	  //Debugging System.out.printf("%s%s %n",ev, " Services added to node");
        	  start = start+length+1;
        	  length = received.substring(start).indexOf(";");
        	  String Pos = received.substring(start, start+length);
        	  //Debugging System.out.printf("%s%s %n","Creating position ", Pos);
        	  createPos(Pos,node, demoNodeManager,name);
        	  start = start+length+1;
        	  length = received.substring(start).indexOf(";");
        	  String Con = received.substring(start, start+length);
        	  //Debugging System.out.printf("%s%s %n","Creating connections ", Con);
        	  createConnections (Con,node, demoNodeManager, name);
        	  UaNode fbfolder = server.getAddressSpace().findNode(new NodeId(ns, "Model_logic"));
        	  UaNode fbnode = createFb(name+"_fb",fbfolder,demoNodeManager);
        	  start = received.indexOf("%")+1;
        	  length = received.substring(start).indexOf(";");
        	  String fbevents = received.substring(start, start+length);
        	  //Debugging System.out.printf("%s%s %n","Creating fbEvents ", fbevents);
        	  createfbEvents(fbevents, fbnode, demoNodeManager,name+"_fb","In");
        	  start = start+length+1;
        	  length = received.substring(start).indexOf(";");
        	  String data = received.substring(start, start+length);
        	  //Debugging System.out.printf("%s%s %n","Creating fbData ", data);
        	  createfbData(data, fbnode, demoNodeManager,name+"_fb","In");
          }
          
          //Initialization inito;Device_name;Event1:Event2;Data1:Data2;
          // adds output events and data into the software logic
          if (received.substring(0, 5).equals("inito")) {
        	  int ns = demoNodeManager.getNamespaceIndex();
        	  int start = received.indexOf(";")+1;
        	  int length = received.substring(start).indexOf(";");
        	  String name = received.substring(start, start+length);
        	  UaNode functionblock = server.getAddressSpace().findNode(new NodeId(ns, name+"_fb"));
        	  start = start+length+1;
        	  length = received.substring(start).indexOf(";");
        	  String fbevents = received.substring(start, start+length);
        	  createfbEvents(fbevents, functionblock, demoNodeManager,name+"_fb","Out");
        	  start = start+length+1;
        	  length = received.substring(start).indexOf(";");
        	  String data = received.substring(start, start+length);
        	  createfbData(data, functionblock, demoNodeManager,name+"_fb","Out");
          }
          
          //Read data req;Device_name;WantedVariable;
          if (received.substring(0, 3).equals("req")) {
        	  
          }
          
          //Update value update;Device_name;Service;Free/Running;
          // updates state machine and sets named service to true
          if (received.substring(0, 6).equals("update")) {
        	  int start = received.indexOf(";")+1;
        	  int length = received.substring(start).indexOf(";");
        	  String name = received.substring(start, start+length);
        	  start = start+length+1;
        	  length = received.substring(start).indexOf(";");
        	  String event = received.substring(start, start+length);
        	  start = start+length+1;
        	  length = received.substring(start).indexOf(";");
        	  String status = received.substring(start, start+length);
        	  int ns = demoNodeManager.getNamespaceIndex();
        	  //browse events of name and update event to True else False
        	  UaNode services = server.getAddressSpace().findNode(new NodeId(ns, name+"_Services"));
        	  UaReference[] ref = services.getForwardReferences();
        	  for (UaReference refs : ref) {
        		  String nodename = refs.getTargetNode().getDisplayName().getText();
        		  //System.out.printf("%s%s %n","Service ", nodename);
        		  MultiStateDiscreteType service = null;
        		  if(!nodename.equals("FolderType")) {
        			  service = (MultiStateDiscreteType) server.getAddressSpace().findNode(new NodeId(ns, nodename));
        		  }
        		  //System.out.printf("%s%s %n","Nodename ", nodename);
        		  //System.out.printf("%s%s %n","Name and event ", name+"_"+event);
        		  if (nodename.equals(name+"_"+event) && !nodename.equals("FolderType")) {
        			  service.setValue(service.getEnumStrings()[1]);
        		  }
        		  else if(!nodename.equals("FolderType")) {
        			  service.setValue(service.getEnumStrings()[0]);
        		  }
        	  }
        	  //System.out.printf("%s%s %n","Before ", status);
        	  MultiStateDiscreteType state = (MultiStateDiscreteType) server.getAddressSpace().findNode(new NodeId(ns, name+"_state"));
        	  if (status.equals("Free")) {
        		  state.setValue(state.getEnumStrings()[0]);
        	  }
        	  if (status.equals("Running")) {
        		  state.setValue(state.getEnumStrings()[1]);
        		  //System.out.printf("%s %n","After");
        	  }
        	  if (status.equals("Stopped")) {
        		  state.setValue(state.getEnumStrings()[2]);
        		  //System.out.printf("%s %n","After");
        	  }
        	  if (status.equals("Malfunctioning")) {
        		  state.setValue(state.getEnumStrings()[3]);
        		  //System.out.printf("%s %n","After");
        	  }
        	}
          
          // Sends confirmation to nxtSTUDIO that message has been received and acknowledged
          byte[] res = "recieved".getBytes();
          DatagramPacket responce = new DatagramPacket(res, res.length, address, port);
          try {
			Socket.send(responce);
          	} catch (IOException e) {
			Socket.close();
			e.printStackTrace();
			}
        received = null;
        buf = new byte[256];
    	}
    	System.out.println("Closing the socket");
    	Socket.close();
    }
    
    private int createConnections(String name, UaNode parent, NodeManagerUaNode myNodeManager, String devname) throws StatusException
    {
    	int i = 0;
    	UaNode folder = myNodeManager.createInstance(FolderType.class, devname + "_Connections");
    	parent.addReference(folder, Identifiers.HasComponent,false);
    	MultiStateDiscreteType variable = null;
    	LocalizedText[] list = {new LocalizedText("pos","eng")};
    	if (name != null);{
    		String eventname = null;
    		if(name.indexOf(":") != -1) {
    		eventname = name.substring(0,name.indexOf(":"));
    		}
    		else {
    			eventname = name;
    		}
    		int start = name.indexOf(":")+1;
    		if (name.length() != 0) {
    		variable = myNodeManager.createInstance(MultiStateDiscreteType.class, devname + "_" + eventname);
    		folder.addComponent(variable);
    		variable.setEnumStrings(list);
    		variable.setValue(eventname);
    		i = i+1;
    		}
    		int cont = 0;
    		if (start != 0) {
    			cont = 1;
    		}
    		while (cont == 1){
    			if (name.substring(start).indexOf(":") == -1) {
    				cont = 0;
    				eventname = name.substring(start);
    			}
    			else {
    				eventname = name.substring(start, start+name.substring(start).indexOf(":"));
    				start = start+name.substring(start).indexOf(":")+1;
    			}	
    			variable = myNodeManager.createInstance(MultiStateDiscreteType.class, devname + "_" +eventname);
	    		folder.addComponent(variable);
	    		variable.setEnumStrings(list);
	    		variable.setValue(eventname);
	    		i=i+1;
    		}
    	}
		return i;
		}
    
    private MultiStateDiscreteType createPos(String pos, UaNode parent, NodeManagerUaNode myNodeManager, String name) throws StatusException
	{
    	MultiStateDiscreteType variable = myNodeManager.createInstance(MultiStateDiscreteType.class, name+"_position");
    	parent.addReference(variable, Identifiers.HasComponent,false);
    	//variable.getFalseStateNode().setValue("Stopped");
    	//variable.getTrueStateNode().setValue("Running");
    	variable.setValue(pos);
		return variable;}
    
    
    private int createEvents(String name, UaNode parent, NodeManagerUaNode myNodeManager,String devname) throws StatusException
	{
    	int i = 0;
    	UaNode folder = myNodeManager.createInstance(FolderType.class, devname+"_Services");
    	parent.addReference(folder, Identifiers.HasComponent,false);
    	LocalizedText[] list = {new LocalizedText("Idle","eng"),new LocalizedText("Running","eng")};
    	MultiStateDiscreteType variable = null;
    	if (name != null);{
    		String eventname = null;
    		if(name.indexOf(":") != -1) {
    		eventname = name.substring(0,name.indexOf(":"));
    		}
    		else {
    			eventname = name;
    		}
    		int start = name.indexOf(":")+1;
    		if (name.length() != 0) {
    		variable = myNodeManager.createInstance(MultiStateDiscreteType.class, devname + "_" +eventname);
    		folder.addComponent(variable);
    		variable.setEnumStrings(list);
    		variable.setValue(variable.getEnumStrings()[0]);
    		i = i+1;
    		}
    		int cont = 0;
    		if (start != 0) {
    			cont = 1;
    		}
    		while (cont == 1){
    			if (name.substring(start).indexOf(":") == -1) {
    				cont = 0;
    				eventname = name.substring(start);
    			}
    			else {
    				eventname = name.substring(start, start+name.substring(start).indexOf(":"));
    				start = start+name.substring(start).indexOf(":")+1;
    			}	
    			variable = myNodeManager.createInstance(MultiStateDiscreteType.class, devname + "_" +eventname);
	    		folder.addComponent(variable);
	    		variable.setEnumStrings(list);
	    		variable.setValue(variable.getEnumStrings()[0]);
	    		i=i+1;
    		}
    	}
		return i;
		}
    
    private int createfbEvents(String name, UaNode parent, NodeManagerUaNode myNodeManager,String devname, String place) throws StatusException
	{
    	int i = 0;
    	UaNode folder = myNodeManager.createInstance(FolderType.class, devname+"_Events"+place);
    	parent.addReference(folder, Identifiers.HasComponent,false);
    	if (name != null);{
    		String eventname = null;
    		MultiStateDiscreteType variable = null;
    		LocalizedText[] list = {new LocalizedText("False","eng"),new LocalizedText("True","eng")};
    		if(name.indexOf(":") != -1) {
    		eventname = name.substring(0,name.indexOf(":"));
    		}
    		else {
    			eventname = name;
    		}
    		int start = name.indexOf(":")+1;
    		if (name.length() != 0) {
    		variable = myNodeManager.createInstance(MultiStateDiscreteType.class, devname + "_" +eventname+"_"+place);
    		folder.addComponent(variable);
    		variable.setEnumStrings(list);
    		variable.setValue(variable.getEnumStrings()[0]);
    		i = i+1;
    		}
    		int cont = 0;
    		if (start != 0) {
    			cont = 1;
    		}
    		while (cont == 1){
    			if (name.substring(start).indexOf(":") == -1) {
    				cont = 0;
    				eventname = name.substring(start);
    			}
    			else {
    				eventname = name.substring(start, start+name.substring(start).indexOf(":"));
    				start = start+name.substring(start).indexOf(":")+1;
    			}	
    			variable = myNodeManager.createInstance(MultiStateDiscreteType.class, devname + "_" +eventname+"_"+place);
	    		folder.addComponent(variable);
	    		variable.setEnumStrings(list);
	    		variable.setValue(variable.getEnumStrings()[0]);
	    		i=i+1;
    		}
    	}
		return i;
		}
    
    private int createfbData(String name, UaNode parent, NodeManagerUaNode myNodeManager,String devname, String place) throws StatusException
	{
    	int i = 0;
    	UaNode folder;
    	folder = myNodeManager.createInstance(FolderType.class, devname+"_Data"+place);
    	parent.addReference(folder, Identifiers.HasComponent,false);
    	if (name != null);{
    		String eventname = null;
    		MultiStateDiscreteType variable = null;
    		LocalizedText[] list = {new LocalizedText("False","eng"),new LocalizedText("True","eng")};
    		if(name.indexOf(":") != -1) {
    		eventname = name.substring(0,name.indexOf(":"));
    		}
    		else {
    			eventname = name;
    		}
    		int start = name.indexOf(":")+1;
    		if (name.length() != 0) {
    		variable = myNodeManager.createInstance(MultiStateDiscreteType.class, devname + "_"+place+"_" +eventname);
    		folder.addComponent(variable);
    		variable.setEnumStrings(list);
    		variable.setValue(variable.getEnumStrings()[0]);
    		i = i+1;
    		}
    		int cont = 0;
    		if (start != 0) {
    			cont = 1;
    		}
    		while (cont == 1){
    			if (name.substring(start).indexOf(":") == -1) {
    				cont = 0;
    				eventname = name.substring(start);
    			}
    			else {
    				eventname = name.substring(start, start+name.substring(start).indexOf(":"));
    				start = start+name.substring(start).indexOf(":")+1;
    			}	
    			variable = myNodeManager.createInstance(MultiStateDiscreteType.class, devname + "_"+place+"_" +eventname);
	    		folder.addComponent(variable);
	    		variable.setEnumStrings(list);
	    		variable.setValue(variable.getEnumStrings()[0]);
	    		i=i+1;
    		}
    	}
		return i;
		}
    
    private MultiStateDiscreteType createState(String name, UaNode parent, NodeManagerUaNode myNodeManager) throws StatusException
	{
    	MultiStateDiscreteType variable = myNodeManager.createInstance(MultiStateDiscreteType.class, name);
    	parent.addReference(variable, Identifiers.HasComponent,false);
    	//variable.getFalseStateNode().setValue("Stopped");
    	//variable.getTrueStateNode().setValue("Running");
    	LocalizedText[] list = {new LocalizedText("Idle","eng"),new LocalizedText("Running","eng"),new LocalizedText("Manually stopped","eng"),new LocalizedText("Malfunctioning","eng")};
    	variable.setEnumStrings(list);
    	variable.setValue(variable.getEnumStrings()[0]);
		return variable;}
    
    private UaNode createFb(String name, UaNode parent, NodeManagerUaNode myNodeManager)
	{
		UaNode node = myNodeManager.createInstance(CtrlTaskTypeNode.class, name);
		try {
		parent.addReference(node, Identifiers.HasComponent,false);
		
		//TypeDefinitionBasedNodeBuilderConfiguration.Builder conf =
		//TypeDefinitionBasedNodeBuilderConfiguration.builder().build();
		//conf.addOptional(UaBrowsePath.from(Ids.LimitAlarmType, UaQualifiedName.standard("HighHighLimit")));
		//conf.addOptional(UaBrowsePath.from(Ids.LimitAlarmType, UaQualifiedName.standard("HighLimit")));
		//conf.addOptional(UaBrowsePath.from(Ids.LimitAlarmType, UaQualifiedName.standard("LowLimit")));
		//conf.addOptional(UaBrowsePath.from(Ids.LimitAlarmType, UaQualifiedName.standard("LowLowLimit")));
		//conf.build()
		
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
		return node;
	}
    

    private DeviceType createDeviceType(String name, UaNode parent, NodeManagerUaNode myNodeManager)
	{
		DeviceType device = myNodeManager.createInstance(DeviceType.class, name);
		try {
		parent.addReference(device, Identifiers.HasComponent,false);
		
		//TypeDefinitionBasedNodeBuilderConfiguration.Builder conf =
		//TypeDefinitionBasedNodeBuilderConfiguration.builder().build();
		//conf.addOptional(UaBrowsePath.from(Ids.LimitAlarmType, UaQualifiedName.standard("HighHighLimit")));
		//conf.addOptional(UaBrowsePath.from(Ids.LimitAlarmType, UaQualifiedName.standard("HighLimit")));
		//conf.addOptional(UaBrowsePath.from(Ids.LimitAlarmType, UaQualifiedName.standard("LowLimit")));
		//conf.addOptional(UaBrowsePath.from(Ids.LimitAlarmType, UaQualifiedName.standard("LowLowLimit")));
		//conf.build()
		
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
		return device;
	}
} 




