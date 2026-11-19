using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class TlsClientProtocol : TlsProtocol
{
	protected TlsClient m_tlsClient;

	internal TlsClientContextImpl m_tlsClientContext;

	protected IDictionary<int, TlsAgreement> m_clientAgreements;

	internal OfferedPsks.BindersConfig m_clientBinders;

	protected ClientHello m_clientHello;

	protected TlsKeyExchange m_keyExchange;

	protected TlsAuthentication m_authentication;

	protected CertificateStatus m_certificateStatus;

	protected CertificateRequest m_certificateRequest;

	protected override TlsContext Context => null;

	internal override AbstractTlsContext ContextAdmin => null;

	protected override TlsPeer Peer => null;

	public TlsClientProtocol()
	{
	}

	public TlsClientProtocol(Stream stream)
	{
	}

	public TlsClientProtocol(Stream input, Stream output)
	{
	}

	public virtual void Connect(TlsClient tlsClient)
	{
	}

	protected override void BeginHandshake()
	{
	}

	protected override void CleanupHandshake()
	{
	}

	protected virtual void Handle13HandshakeMessage(short type, HandshakeMessageInput buf)
	{
	}

	protected override void HandleHandshakeMessage(short type, HandshakeMessageInput buf)
	{
	}

	protected virtual void HandleServerCertificate()
	{
	}

	protected virtual void HandleSupplementalData(IList<SupplementalDataEntry> serverSupplementalData)
	{
	}

	protected virtual void Process13HelloRetryRequest(ServerHello helloRetryRequest)
	{
	}

	protected virtual void Process13ServerHello(ServerHello serverHello, bool afterHelloRetryRequest)
	{
	}

	protected virtual void Process13ServerHelloCoda(ServerHello serverHello, bool afterHelloRetryRequest)
	{
	}

	protected virtual void ProcessServerHello(ServerHello serverHello)
	{
	}

	protected virtual void Receive13CertificateRequest(MemoryStream buf, bool postHandshakeAuth)
	{
	}

	protected virtual void Receive13EncryptedExtensions(MemoryStream buf)
	{
	}

	protected virtual void Receive13NewSessionTicket(MemoryStream buf)
	{
	}

	protected virtual void Receive13ServerCertificate(MemoryStream buf)
	{
	}

	protected virtual void Receive13ServerCertificateVerify(MemoryStream buf)
	{
	}

	protected virtual void Receive13ServerFinished(MemoryStream buf)
	{
	}

	protected virtual void ReceiveCertificateRequest(MemoryStream buf)
	{
	}

	protected virtual void ReceiveNewSessionTicket(MemoryStream buf)
	{
	}

	protected virtual ServerHello ReceiveServerHelloMessage(MemoryStream buf)
	{
		return null;
	}

	protected virtual void Send13ClientHelloRetry()
	{
	}

	protected virtual void SendCertificateVerifyMessage(DigitallySigned certificateVerify)
	{
	}

	protected virtual void SendClientHello()
	{
	}

	protected virtual void SendClientHelloMessage()
	{
	}

	protected virtual void SendClientKeyExchange()
	{
	}

	protected virtual void Skip13CertificateRequest()
	{
	}

	protected virtual void Skip13ServerCertificate()
	{
	}
}
