package fi.aalto.demonstrator.server;

import java.util.List;

import org.opcfoundation.ua.builtintypes.NodeId;
import org.opcfoundation.ua.builtintypes.ExpandedNodeId;
import org.opcfoundation.ua.core.UserTokenType;
import org.opcfoundation.ua.core.StatusCodes;
import org.opcfoundation.ua.core.NodeClass;
import org.opcfoundation.ua.builtintypes.QualifiedName;
import org.opcfoundation.ua.core.NodeAttributes;
import org.opcfoundation.ua.core.MonitoringParameters;
import org.opcfoundation.ua.core.MonitoringFilter;
import org.opcfoundation.ua.core.AggregateFilterResult;
import org.opcfoundation.ua.core.ViewDescription;
import org.opcfoundation.ua.builtintypes.UnsignedInteger;
import org.opcfoundation.ua.utils.NumericRange;
import org.opcfoundation.ua.core.MonitoringMode;
import org.opcfoundation.ua.core.Attributes;

import com.prosysopc.ua.server.NodeManagerListener;
import com.prosysopc.ua.server.ServiceContext;
import com.prosysopc.ua.nodes.UaNode;
import com.prosysopc.ua.nodes.UaReferenceType;
import com.prosysopc.ua.StatusException;
import com.prosysopc.ua.client.UaClient;
import com.prosysopc.ua.server.Subscription;
import com.prosysopc.ua.server.MonitoredDataItem;
import com.prosysopc.ua.nodes.UaReference;
import com.prosysopc.ua.MonitoredItemBase;
import com.prosysopc.ua.server.UaServer;

//import fi.aalto.demonstrator.server.DemonstratorDataItemListener;

public class DemonstratorNodeManagerListener implements NodeManagerListener {

	private UaClient client; 
	private UaServer server; 
	
	public DemonstratorNodeManagerListener (UaClient client, UaServer server) {
		this.client = client;
		this.server = server;
	}

	@Override
	public void onAddNode(ServiceContext serviceContext,
            org.opcfoundation.ua.builtintypes.NodeId parentNodeId,
            UaNode parent,
            org.opcfoundation.ua.builtintypes.NodeId nodeId,
            org.opcfoundation.ua.core.NodeClass nodeClass,
            org.opcfoundation.ua.builtintypes.QualifiedName browseName,
            org.opcfoundation.ua.core.NodeAttributes attributes,
            UaReferenceType referenceType,
            org.opcfoundation.ua.builtintypes.ExpandedNodeId typeDefinitionId,
            UaNode typeDefinition)
            throws StatusException {
		checkUserAccess(serviceContext);
	}

	@Override
	public void onAfterAddNode(ServiceContext serviceContext,
            org.opcfoundation.ua.builtintypes.NodeId parentNodeId,
            UaNode parent,
            org.opcfoundation.ua.builtintypes.NodeId nodeId,
            UaNode node,
            org.opcfoundation.ua.core.NodeClass nodeClass,
            org.opcfoundation.ua.builtintypes.QualifiedName browseName,
            org.opcfoundation.ua.core.NodeAttributes attributes,
            UaReferenceType referenceType,
            org.opcfoundation.ua.builtintypes.ExpandedNodeId typeDefinitionId,
            UaNode typeDefinition)
            throws StatusException {
	}
	
	@Override
	public boolean onBrowseNode(ServiceContext serviceContext,
			ViewDescription view, NodeId nodeId, UaNode node,
			UaReference reference) {
		return true;
	}

	@Override
	public void onDeleteNode(ServiceContext serviceContext, NodeId nodeId,
			UaNode node, boolean deleteTargetReferences) throws StatusException {
		checkUserAccess(serviceContext);
	}

	@Override
	public void onGetReferences(ServiceContext serviceContext,
			ViewDescription viewDescription, NodeId nodeId, UaNode node,
			List<UaReference> references) {
	}

	@Override
	public void onAddReference(ServiceContext serviceContext,
			NodeId sourceNodeId, UaNode sourceNode,
			ExpandedNodeId targetNodeId, UaNode targetNode,
			NodeId referenceTypeId, UaReferenceType referenceType,
			boolean isForward) throws StatusException {
		checkUserAccess(serviceContext);
	}

	@Override
	public void onAfterAddReference(ServiceContext serviceContext,
            org.opcfoundation.ua.builtintypes.NodeId sourceNodeId,
            UaNode sourceNode,
            org.opcfoundation.ua.builtintypes.ExpandedNodeId targetNodeId,
            UaNode targetNode,
            org.opcfoundation.ua.builtintypes.NodeId referenceTypeId,
            UaReferenceType referenceType,
            boolean isForward)
            throws StatusException {
	}
	
	@Override
	public void onDeleteReference(ServiceContext serviceContext,
			NodeId sourceNodeId, UaNode sourceNode,
			ExpandedNodeId targetNodeId, UaNode targetNode,
			NodeId referenceTypeId, UaReferenceType referenceType,
			boolean isForward, boolean deleteBidirectional)
			throws StatusException {
		checkUserAccess(serviceContext);
	}

	@Override
	public void onCreateMonitoredDataItem(ServiceContext serviceContext,
			Subscription subscription, NodeId nodeId, UaNode node,
			UnsignedInteger attributeId, NumericRange indexRange,
			MonitoringParameters params, MonitoringFilter filter,
			AggregateFilterResult filterResult, MonitoringMode monitoringMode) throws StatusException {
	}

	@Override
	public void onAfterCreateMonitoredDataItem(ServiceContext serviceContext,
			Subscription subscription, MonitoredDataItem item) {
		try {
		    int sourceNs = 2; // TODO get this from somewhere?
		    String name = item.getNodeId().getValue().toString();
		    System.out.println("onCreateMonitoredDataItem: " + name);
		    com.prosysopc.ua.client.MonitoredDataItem clientMonitoredDataItem = new com.prosysopc.ua.client.MonitoredDataItem(new NodeId(sourceNs, name), Attributes.Value, MonitoringMode.Reporting);
		    //clientMonitoredDataItem.setDataChangeListener(new AppMonitoredDataItemListener(this.server));
		    com.prosysopc.ua.client.Subscription clientSubscription = client.getSubscriptions()[0];
		    clientSubscription.addItem(clientMonitoredDataItem);
		} catch (Exception e) {
		    System.out.println(e.getMessage());
	    }
	}

	@Override
	public void onModifyMonitoredDataItem(ServiceContext serviceContext,
			Subscription subscription, MonitoredDataItem item, UaNode node,
			MonitoringParameters params, MonitoringFilter filter,
			AggregateFilterResult filterResult) {
	}

	@Override
	public void onAfterModifyMonitoredDataItem(ServiceContext serviceContext,
			Subscription subscription, MonitoredDataItem item) {
	}

	@Override
	public void onDeleteMonitoredDataItem(ServiceContext serviceContext,
			Subscription subscription, MonitoredDataItem monitoredItem) {
	}

	@Override
	public void onAfterDeleteMonitoredDataItem(ServiceContext serviceContext,
			Subscription subscription, MonitoredDataItem item) {
		try {
	        String name = item.getNodeId().getValue().toString();
		    System.out.println("onAfterDeleteMonitoredDataItem: " + name);	
		    com.prosysopc.ua.client.Subscription clientSubscription = client.getSubscriptions()[0];	
		    com.prosysopc.ua.MonitoredItemBase[] clientMonitoredItems = clientSubscription.getItems(); 
		    for (com.prosysopc.ua.MonitoredItemBase clientItem : clientMonitoredItems) {
			    String clientItemName = clientItem.getNodeId().getValue().toString();
			    if (name.equals(clientItemName)) clientSubscription.removeItem(clientItem);
		    }
		} catch (Exception e) {
		    System.out.println(e.getMessage());
	    }
	}

	private void checkUserAccess(ServiceContext serviceContext)
			throws StatusException {
		if (serviceContext.getSession().getUserIdentity().getType().equals(UserTokenType.Anonymous))
			throw new StatusException(StatusCodes.Bad_UserAccessDenied);
	}

}
