using System.Collections.Generic;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class DtlsServerProtocol : DtlsProtocol
{
	protected internal class ServerHandshakeState
	{
		internal TlsServer server;

		internal TlsServerContextImpl serverContext;

		internal TlsSession tlsSession;

		internal SessionParameters sessionParameters;

		internal TlsSecret sessionMasterSecret;

		internal SessionParameters.Builder sessionParametersBuilder;

		internal ClientHello clientHello;

		internal IDictionary<int, byte[]> serverExtensions;

		internal bool expectSessionTicket;

		internal TlsKeyExchange keyExchange;

		internal TlsCredentials serverCredentials;

		internal CertificateRequest certificateRequest;

		internal TlsHeartbeat heartbeat;

		internal short heartbeatPolicy;
	}

	protected bool m_verifyRequests;

	public virtual bool VerifyRequests
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual DtlsTransport Accept(TlsServer server, DatagramTransport transport)
	{
		return null;
	}

	public virtual DtlsTransport Accept(TlsServer server, DatagramTransport transport, DtlsRequest request)
	{
		return null;
	}

	internal virtual void AbortServerHandshake(ServerHandshakeState state, DtlsRecordLayer recordLayer, short alertDescription)
	{
	}

	internal virtual DtlsTransport ServerHandshake(ServerHandshakeState state, DtlsRecordLayer recordLayer, DtlsRequest request)
	{
		return null;
	}

	protected virtual byte[] GenerateCertificateRequest(ServerHandshakeState state, CertificateRequest certificateRequest)
	{
		return null;
	}

	protected virtual byte[] GenerateCertificateStatus(ServerHandshakeState state, CertificateStatus certificateStatus)
	{
		return null;
	}

	protected virtual byte[] GenerateNewSessionTicket(ServerHandshakeState state, NewSessionTicket newSessionTicket)
	{
		return null;
	}

	internal virtual byte[] GenerateServerHello(ServerHandshakeState state, DtlsRecordLayer recordLayer)
	{
		return null;
	}

	protected virtual void CancelSession(ServerHandshakeState state)
	{
	}

	protected virtual bool EstablishSession(ServerHandshakeState state, TlsSession sessionToResume)
	{
		return false;
	}

	protected virtual void InvalidateSession(ServerHandshakeState state)
	{
	}

	protected virtual void NotifyClientCertificate(ServerHandshakeState state, Certificate clientCertificate)
	{
	}

	protected virtual void ProcessClientCertificate(ServerHandshakeState state, byte[] body)
	{
	}

	protected virtual void ProcessCertificateVerify(ServerHandshakeState state, byte[] body, TlsHandshakeHash handshakeHash)
	{
	}

	protected virtual void ProcessClientHello(ServerHandshakeState state, byte[] body)
	{
	}

	protected virtual void ProcessClientHello(ServerHandshakeState state, ClientHello clientHello)
	{
	}

	protected virtual void ProcessClientKeyExchange(ServerHandshakeState state, byte[] body)
	{
	}

	protected virtual void ProcessClientSupplementalData(ServerHandshakeState state, byte[] body)
	{
	}

	protected virtual bool ExpectCertificateVerifyMessage(ServerHandshakeState state)
	{
		return false;
	}
}
