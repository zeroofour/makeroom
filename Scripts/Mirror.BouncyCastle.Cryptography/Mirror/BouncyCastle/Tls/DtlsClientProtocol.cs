using System.Collections.Generic;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class DtlsClientProtocol : DtlsProtocol
{
	protected internal class ClientHandshakeState
	{
		internal TlsClient client;

		internal TlsClientContextImpl clientContext;

		internal TlsSession tlsSession;

		internal SessionParameters sessionParameters;

		internal TlsSecret sessionMasterSecret;

		internal SessionParameters.Builder sessionParametersBuilder;

		internal int[] offeredCipherSuites;

		internal IDictionary<int, byte[]> clientExtensions;

		internal IDictionary<int, byte[]> serverExtensions;

		internal bool expectSessionTicket;

		internal IDictionary<int, TlsAgreement> clientAgreements;

		internal OfferedPsks.BindersConfig clientBinders;

		internal TlsKeyExchange keyExchange;

		internal TlsAuthentication authentication;

		internal CertificateStatus certificateStatus;

		internal CertificateRequest certificateRequest;

		internal TlsHeartbeat heartbeat;

		internal short heartbeatPolicy;
	}

	public virtual DtlsTransport Connect(TlsClient client, DatagramTransport transport)
	{
		return null;
	}

	internal virtual void AbortClientHandshake(ClientHandshakeState state, DtlsRecordLayer recordLayer, short alertDescription)
	{
	}

	internal virtual DtlsTransport ClientHandshake(ClientHandshakeState state, DtlsRecordLayer recordLayer)
	{
		return null;
	}

	protected virtual byte[] GenerateCertificateVerify(ClientHandshakeState state, DigitallySigned certificateVerify)
	{
		return null;
	}

	protected virtual byte[] GenerateClientHello(ClientHandshakeState state)
	{
		return null;
	}

	protected virtual byte[] GenerateClientKeyExchange(ClientHandshakeState state)
	{
		return null;
	}

	protected virtual void CancelSession(ClientHandshakeState state)
	{
	}

	protected virtual bool EstablishSession(ClientHandshakeState state, TlsSession sessionToResume)
	{
		return false;
	}

	protected virtual void InvalidateSession(ClientHandshakeState state)
	{
	}

	protected virtual void ProcessCertificateRequest(ClientHandshakeState state, byte[] body)
	{
	}

	protected virtual void ProcessCertificateStatus(ClientHandshakeState state, byte[] body)
	{
	}

	protected virtual byte[] ProcessHelloVerifyRequest(ClientHandshakeState state, byte[] body)
	{
		return null;
	}

	protected virtual void ProcessNewSessionTicket(ClientHandshakeState state, byte[] body)
	{
	}

	protected virtual void ProcessServerCertificate(ClientHandshakeState state, byte[] body)
	{
	}

	protected virtual void ProcessServerHello(ClientHandshakeState state, byte[] body)
	{
	}

	protected virtual void ProcessServerKeyExchange(ClientHandshakeState state, byte[] body)
	{
	}

	protected virtual void ProcessServerSupplementalData(ClientHandshakeState state, byte[] body)
	{
	}

	protected virtual void ReportServerVersion(ClientHandshakeState state, ProtocolVersion server_version)
	{
	}

	protected static byte[] PatchClientHelloWithCookie(byte[] clientHelloBody, byte[] cookie)
	{
		return null;
	}
}
