package fi.aalto.demonstrator.server;

import java.util.Locale;

import org.opcfoundation.ua.builtintypes.LocalizedText;
import org.opcfoundation.ua.builtintypes.NodeId;
import org.opcfoundation.ua.core.Identifiers;

import com.prosysopc.ua.StatusException;
import com.prosysopc.ua.nodes.UaNodeFactoryException;
import com.prosysopc.ua.nodes.UaNode;
import com.prosysopc.ua.server.NodeManagerUaNode;
import com.prosysopc.ua.server.UaInstantiationException;
import com.prosysopc.ua.server.UaServer;
import com.prosysopc.ua.server.nodes.PlainVariable;
import com.prosysopc.ua.server.nodes.UaObjectNode;

public class DemonstratorNodeManager extends NodeManagerUaNode {

	public static final String NAMESPACE = "http://localhost/OPCUA/DemonstratorAddressSpace";

	public DemonstratorNodeManager(UaServer arg0, String arg1) {
		super(arg0, arg1);
	}

	
//does not curerntly do anything can be used to set up folder structure
	private void createAddressSpace() throws StatusException, UaInstantiationException {
		int ns = getNamespaceIndex();
		final UaNode objectsFolder = getServer().getNodeManagerRoot().getObjectsFolder();
		UaNode parent = objectsFolder;

		// Base objects
		createFolder(ns, "Model_logic", parent);
		createFolder(ns, "Hardware", parent);
		
		
		
		return;
	}	

	@Override
	protected void init() throws StatusException, UaNodeFactoryException {
		super.init();

		createAddressSpace();
	}

	/**
	private UaObjectType createType(int ns, String name, UaType parent) throws StatusException
	{
		final NodeId id = new NodeId(ns, name);
		UaObjectType type = new UaObjectTypeNode(this, id, name, Locale.ENGLISH);
		this.addNodeAndReference(parent, type, Identifiers.HasSubtype);

		return type;
	}
	**/
	
	private UaObjectNode createFolder(int ns, String name, UaNode parent)
	{
	    final NodeId id = new NodeId(ns, name);
	    UaObjectNode node = new UaObjectNode(this, id, name, Locale.ENGLISH);
	    node.setTypeDefinitionId(Identifiers.FolderType);
		try {
		    //parent.addReference(node, Identifiers.Organizes, false);
		    this.addNodeAndReference(parent, node, Identifiers.Organizes);
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
		
		return node;
	}

	private <T> PlainVariable<T> createVariable(int ns, String name, T value, NodeId dataTypeId, UaNode parent)
	{
		NodeId id = new NodeId(ns, name);
		PlainVariable<T> variable = new PlainVariable<T>(this, id, name, LocalizedText.NO_LOCALE);
		variable.setDataTypeId(dataTypeId);
		variable.setTypeDefinitionId(Identifiers.BaseDataVariableType);
		parent.addComponent(variable);
		variable.setCurrentValue(value);

		return variable;
	}
	
}
