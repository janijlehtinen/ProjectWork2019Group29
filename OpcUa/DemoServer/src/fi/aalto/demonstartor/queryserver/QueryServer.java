package fi.aalto.demonstartor.queryserver;

import java.util.Locale;
import java.util.Scanner;
import java.io.File;

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
import com.prosysopc.ua.server.UaServer;

import fi.aalto.demonstartor.queryclient.QueryClient;

public class QueryServer {

	protected static String APP_NAME = "QueryServer";
	protected static int TCP_PORT = 51234;
	protected static int HTTP_PORT = 52443;
	protected static boolean enableSessionDiagnostics = false;
	protected UaServer server;
	private QueryClient queryClient;

//main program that creates queryserver sets it up and runs it
	public static void main(String[] args) {

		QueryServer queryServer = new QueryServer();
		queryServer.initialize(TCP_PORT, HTTP_PORT, APP_NAME);
		System.out.print("Queryerver initialized \n");
		queryServer.run(enableSessionDiagnostics);
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
		    server.setDiscoveryServerUrl("opc.tcp://localhost:4840");
		    

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
			server.getSessionManager().setMaxSessionCount(500);
			server.getSessionManager().setMaxSessionTimeout(3600000);
			server.getSubscriptionManager().setMaxSubscriptionCount(500);
			
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
			
			System.out.println("opening client");
		    queryClient = new QueryClient();
		    
		    String keypress = "";
		    boolean runloop = true;
		    
		    Scanner scanner = new Scanner(System.in);
		    
		    do  {
		    	System.out.println("Press any key and Enter to continue... or q to quit");
		    	keypress = scanner.next();
		    	queryClient.run();
		    	
		    	if (keypress.equals("q")) {
		    		System.out.println("Exiting");
		    		scanner.close();
		    		break;
		    	}
		    } while (runloop);
		       
		    
			System.out.println("Closing down...");
			server.shutdown(5, new LocalizedText("Closed by user", Locale.ENGLISH));

		} catch (Exception e) {
			System.out.println(e.getMessage());
			return;
		}
	}

}

