package fi.aalto.demonstrator.server;

import java.util.EnumSet;

import org.opcfoundation.ua.builtintypes.NodeId;
import org.opcfoundation.ua.utils.NumericRange;
import org.opcfoundation.ua.core.TimestampsToReturn;
import org.opcfoundation.ua.builtintypes.DateTime;
import org.opcfoundation.ua.builtintypes.DataValue;
import org.opcfoundation.ua.builtintypes.UnsignedInteger;
import org.opcfoundation.ua.core.AccessLevel;

import com.prosysopc.ua.server.io.IoManagerListener;
import com.prosysopc.ua.server.ServiceContext;
import com.prosysopc.ua.nodes.UaVariable;
import com.prosysopc.ua.StatusException;
import com.prosysopc.ua.nodes.UaNode;
import com.prosysopc.ua.nodes.UaMethod;
import com.prosysopc.ua.WriteAccess;
import com.prosysopc.ua.nodes.UaValueNode;
import java.net.*;
import java.io.*;

public class DemonstratorIoManagerListener implements IoManagerListener {
	
	
	
	@Override
	public EnumSet<AccessLevel> onGetUserAccessLevel(
			ServiceContext serviceContext, NodeId nodeId, UaVariable node) {
		if (node.getHistorizing())
			return EnumSet.of(AccessLevel.CurrentRead,
					AccessLevel.CurrentWrite, AccessLevel.HistoryRead);
		else
			return EnumSet
					.of(AccessLevel.CurrentRead, AccessLevel.CurrentWrite);
	}

	@Override
	public Boolean onGetUserExecutable(ServiceContext serviceContext,
			NodeId nodeId, UaMethod node) {
		return true;
	}

	@Override
	public EnumSet<WriteAccess> onGetUserWriteMask(
			ServiceContext serviceContext, NodeId nodeId, UaNode node) {
		return EnumSet.allOf(WriteAccess.class);
	}

	@Override
	public boolean onReadNonValue(ServiceContext serviceContext, NodeId nodeId,
			UaNode node, UnsignedInteger attributeId, DataValue dataValue)
			throws StatusException {
		return false;
	}

	@Override
	public boolean onReadValue(ServiceContext serviceContext, NodeId nodeId,
			UaValueNode node, NumericRange indexRange,
			TimestampsToReturn timestampsToReturn, DateTime minTimestamp,
			DataValue dataValue) throws StatusException {
	    //System.out.println("DemoServer/onReadValue: " + node.getDisplayName().getText() + " " + dataValue.getValue().getValue());
		return false;
	}
	
	@Override
	public boolean onWriteNonValue(ServiceContext serviceContext,
			NodeId nodeId, UaNode node, UnsignedInteger attributeId,
			DataValue dataValue) throws StatusException {
		return false;
	}

	@Override
	public boolean onWriteValue(ServiceContext serviceContext, NodeId nodeId,
			UaValueNode node, NumericRange indexRange, DataValue dataValue)
			throws StatusException {	

		try {
		    node.setValue(dataValue.getValue().getValue());
		    //System.out.println("DemoServer/onWriteValue: " + node.getDisplayName().getText() + " " + dataValue.getValue().getValue());
		    return true;
		} catch (Exception e) {
		    System.out.println(e.getMessage());
		}

		return false;
	}
	
}
