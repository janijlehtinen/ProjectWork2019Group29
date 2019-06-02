package fi.aalto.demonstartor.queryclient;

import java.io.File;
import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.SocketException;
import java.net.URISyntaxException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.EnumSet;
import java.util.List;
import java.util.Locale;
import java.util.Scanner;

import org.opcfoundation.ua.builtintypes.LocalizedText;
import org.opcfoundation.ua.builtintypes.NodeId;
import org.opcfoundation.ua.cert.DefaultCertificateValidator;
import org.opcfoundation.ua.cert.PkiDirectoryCertificateStore;
import org.opcfoundation.ua.core.ApplicationDescription;
import org.opcfoundation.ua.core.ApplicationType;
import org.opcfoundation.ua.core.EndpointDescription;
import org.opcfoundation.ua.core.ServerCapability;
import org.opcfoundation.ua.core.ServerOnNetwork;
import org.opcfoundation.ua.transport.security.HttpsSecurityPolicy;
import org.opcfoundation.ua.transport.security.KeyPair;

import com.prosysopc.ua.ApplicationIdentity;
import com.prosysopc.ua.SecureIdentityException;
import com.prosysopc.ua.SessionActivationException;
import com.prosysopc.ua.StatusException;
import com.prosysopc.ua.UserIdentity;
import com.prosysopc.ua.client.ServerList;
import com.prosysopc.ua.client.ServerListBase;
import com.prosysopc.ua.client.ServerListException;
import com.prosysopc.ua.client.ServerStatusListener;
import com.prosysopc.ua.client.UaClient;
import com.prosysopc.ua.nodes.UaNode;
import com.prosysopc.ua.server.NodeManagerUaNode;
import com.prosysopc.ua.server.UaServer;
import com.prosysopc.ua.types.di.DeviceType;

public class QueryClient {

	protected UaClient client;
	protected static String APP_NAME = "QueryClient";

	public void run() throws ServerListException, URISyntaxException {
		discover();
	}
	
	protected String[] discoverServer(String uri) throws ServerListException {
		// Discovery Server
		uri = "opc.tcp://localhost:4840";
		
		// Discover a new server list from a discovery server at URI
		ServerListBase serverList;
		serverList = new ServerList(uri);
		
		System.out.println("");
		
		if (serverList.size() == 0 && serverList.getServersOnNetwork().length == 0) {
			System.out.println("No servers found!");
			return null;
		}
		
	    if (!serverList.isEmpty()) {
	    	System.out.println("Local servers:");
	    	System.out.println(String.format("%s - %-40s - %-15s - %-50s - %s", "#", "Name", "Type", "ProductUri", "ApplicationUri"));
	        for (int i = 0; i < serverList.size(); i++) {
	          final ApplicationDescription s = serverList.get(i);
	          System.out.println(String.format("%d - %-40s - %-15s - %-50s - %s", i, s.getApplicationName().getText(),
	              s.getApplicationType(), s.getProductUri(), s.getApplicationUri()));
	        }
	      }
	    
	    int n = serverList.size();
	    List<ServerOnNetwork> serversOnNetwork = Arrays.asList(serverList.getServersOnNetwork());

	  return null;
	}


	  protected boolean discover() throws URISyntaxException, ServerListException {
	    String[] discoveryUrls;
	    discoveryUrls = discoverServer("opc.tcp://localhost:51234/QueryServer");

	    return false;
	  }

}