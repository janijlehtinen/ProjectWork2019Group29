package fi.aalto.demonstrator.server;

import java.util.Locale;
import java.io.File;
import java.io.IOException;
import java.io.BufferedReader;
import java.io.InputStreamReader;

import org.opcfoundation.ua.builtintypes.LocalizedText;
import org.opcfoundation.ua.core.ApplicationDescription;
import org.opcfoundation.ua.core.UserTokenPolicy;
import org.opcfoundation.ua.transport.security.HttpsSecurityPolicy;
import org.opcfoundation.ua.transport.security.KeyPair;
import org.opcfoundation.ua.transport.security.SecurityMode;
import org.opcfoundation.ua.utils.EndpointUtil;
import org.opcfoundation.ua.cert.PkiDirectoryCertificateStore;

import com.prosysopc.ua.ApplicationIdentity;
import com.prosysopc.ua.DefaultUaCertificateValidator;
import com.prosysopc.ua.UaApplication.Protocol;
import com.prosysopc.ua.client.UaClient;
import com.prosysopc.ua.server.UaServer;
import com.prosysopc.ua.types.di.server.DiServerInformationModel;
import com.prosysopc.ua.types.plc.server.PlcServerInformationModel;

import fi.aalto.demonstrator.server.DemonstratorNodeManagerListener;
import fi.aalto.demonstrator.client.DemonstratorClient;
import fi.aalto.demonstrator.server.DemonstratorNodeManager;



public class DemonstratorServer {


	protected static String APP_NAME = "Jack2";
	protected static int TCP_PORT = 51211;
	protected static int HTTP_PORT = 52443;
	protected static boolean enableSessionDiagnostics = false;
	protected DemonstratorNodeManager demoNodeManager;
	protected UaServer server;
	private DemonstratorClient demonstratorClient;

//main program that creates demo server sets it up and runs it
	public static void main(String[] args) {

		DemonstratorServer demoServer = new DemonstratorServer();
		demoServer.initialize(TCP_PORT, HTTP_PORT, APP_NAME);
		System.out.print("Server initialized \n");
		demoServer.createAddressSpace();
		demoServer.run(enableSessionDiagnostics);
	}
	
	
	protected void initialize(int port, int httpsPort, String applicationName) {

		try {
		    server = new UaServer();
		    
		    ApplicationDescription appDescription = new ApplicationDescription();
		    appDescription.setApplicationName(new LocalizedText(applicationName, Locale.ENGLISH));
		    appDescription.setApplicationUri("urn:Group29:" + applicationName);
			appDescription.setProductUri("urn:prosysopc.com:" + applicationName);
		    server.setPort(Protocol.OpcTcp, port);
		    server.setPort(Protocol.Https, httpsPort);
		    server.setServerName(applicationName);
		    server.setBindAddresses(EndpointUtil.getInetAddresses());
		    server.setDiscoveryServerUrl("opc.tcp://192.168.0.50:4840");

		    final PkiDirectoryCertificateStore certificateStore = new PkiDirectoryCertificateStore();
		    final DefaultUaCertificateValidator validator = new DefaultUaCertificateValidator(certificateStore);
			server.setCertificateValidator(validator);
		    File privatePath = new File(certificateStore.getBaseDir(), "private");
			KeyPair issuerCertificate = ApplicationIdentity.loadOrCreateIssuerCertificate(
					"DemonstratorCA", privatePath, "demonstrator", 3650, false);
			int[] keySizes = null;
			final ApplicationIdentity identity = ApplicationIdentity
					.loadOrCreateCertificate(appDescription, "Demonstrator",
					"demonstrator", privatePath, null, keySizes, true);
			String hostName = ApplicationIdentity.getActualHostName();
			identity.setHttpsCertificate(ApplicationIdentity
					.loadOrCreateHttpsCertificate(appDescription, hostName,
					"demonstrator", issuerCertificate, privatePath, true));
		    server.setApplicationIdentity(identity);

			server.setSecurityModes(SecurityMode.ALL);
			server.getHttpsSettings().setHttpsSecurityPolicies(HttpsSecurityPolicy.ALL);
			server.addUserTokenPolicy(UserTokenPolicy.ANONYMOUS);
			server.init();
			//initBuildInfo();
			server.getSessionManager().setMaxSessionCount(500);
			server.getSessionManager().setMaxSessionTimeout(3600000);
			server.getSubscriptionManager().setMaxSubscriptionCount(500);
			
		} catch (Exception e) {
			server.close();
			System.out.println(e.getMessage());
			return;
		}

	}

//creates address space and sets listeners all meaningful changes here
	protected void createAddressSpace() {
		try {
			//this.demonstratorClient.connect();
			//load device type and configuration types to server 
			server.registerModel(DiServerInformationModel.MODEL);
			server.getAddressSpace().loadModel(DiServerInformationModel.class.getResource("Opc.Ua.Di.NodeSet2.xml").toURI());
			server.registerModel(PlcServerInformationModel.MODEL);
			server.getAddressSpace().loadModel(PlcServerInformationModel.class.getResource("Opc.Ua.Plc.NodeSet2.xml").toURI());
			
			//creates DemonstratorNodeManager.java
			demoNodeManager = new DemonstratorNodeManager(server, DemonstratorNodeManager.NAMESPACE);
			demoNodeManager.getIoManager().addListeners(new DemonstratorIoManagerListener());
			demoNodeManager.addListener(new DemonstratorNodeManagerListener(null, this.server));
			
			//this.demonstratorClient.socket();
		} catch (Exception e) {
			server.close();
			System.out.println(e.getMessage());
			return;
		}
	}
	
	
	//just runs the server no need to change
	protected void run(boolean enableSessionDiagnostics) {
		try {
			server.start();
			if (enableSessionDiagnostics)
				server.getNodeManagerRoot().getServerData().getServerDiagnosticsNode().setEnabled(true);

			//thread.start();
			
			//waitForEnter();
			
			System.out.println("opening client");
		    demonstratorClient = new DemonstratorClient();
		    demonstratorClient.run(server, demoNodeManager);
			
			
			System.out.println("Closing down...");
			server.shutdown(5, new LocalizedText("Closed by user", Locale.ENGLISH));
			//System.out.println("Closed.");

		} catch (Exception e) {
			System.out.println(e.getMessage());
			return;
		}
	}

	
//just for closing down the server	
	protected void waitForEnter() {
		try {
			//reads data input from user
		    BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		    System.out.println("opening client");
		    demonstratorClient = new DemonstratorClient();
		    demonstratorClient.run(server, demoNodeManager);
            System.out.print("DemonstratorServer: Press enter to close");
            br.readLine();
		} catch (Exception e) {
			server.close();
			System.out.println(e.getMessage());
			return;
		}
   }
}
