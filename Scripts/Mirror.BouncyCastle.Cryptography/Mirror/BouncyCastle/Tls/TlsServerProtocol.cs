using System.Collections.Generic;
using System.IO;

namespace Mirror.BouncyCastle.Tls;

public class TlsServerProtocol : TlsProtocol
{
	protected TlsServer m_tlsServer;

	internal TlsServerContextImpl m_tlsServerContext;

	protected int[] m_offeredCipherSuites;

	protected TlsKeyExchange m_keyExchange;

	protected CertificateRequest m_certificateRequest;

	protected override TlsContext Context => null;

	internal override AbstractTlsContext ContextAdmin => null;

	protected override TlsPeer Peer => null;

	public TlsServerProtocol()
	{
	}

	public TlsServerProtocol(Stream stream)
	{
	}

	public TlsServerProtocol(Stream input, Stream output)
	{
	}

	public void Accept(TlsServer tlsServer)
	{
	}

	protected override void CleanupHandshake()
	{
	}

	protected virtual bool ExpectCertificateVerifyMessage()
	{
		return false;
	}

	protected virtual ServerHello Generate13HelloRetryRequest(ClientHello clientHello)
	{
		return null;
	}

	protected virtual ServerHello Generate13ServerHello(ClientHello clientHello, HandshakeMessageInput clientHelloMessage, bool afterHelloRetryRequest)
	{
		return null;
	}

	protected virtual ServerHello GenerateServerHello(ClientHello clientHello, HandshakeMessageInput clientHelloMessage)
	{
		return null;
	}

	protected virtual void Handle13HandshakeMessage(short type, HandshakeMessageInput buf)
	{
	}

	protected override void HandleHandshakeMessage(short type, HandshakeMessageInput buf)
	{
	}

	protected override void HandleAlertWarningMessage(short alertDescription)
	{
	}

	protected virtual void NotifyClientCertificate(Certificate clientCertificate)
	{
	}

	protected virtual void Receive13ClientCertificate(MemoryStream buf)
	{
	}

	protected void Receive13ClientCertificateVerify(MemoryStream buf)
	{
	}

	protected virtual void Receive13ClientFinished(MemoryStream buf)
	{
	}

	protected virtual void ReceiveCertificateMessage(MemoryStream buf)
	{
	}

	protected virtual void ReceiveCertificateVerifyMessage(MemoryStream buf)
	{
	}

	protected virtual ClientHello ReceiveClientHelloMessage(MemoryStream buf)
	{
		return null;
	}

	protected virtual void ReceiveClientKeyExchangeMessage(MemoryStream buf)
	{
	}

	protected virtual void Send13EncryptedExtensionsMessage(IDictionary<int, byte[]> serverExtensions)
	{
	}

	protected virtual void Send13ServerHelloCoda(ServerHello serverHello, bool afterHelloRetryRequest)
	{
	}

	protected virtual void SendCertificateRequestMessage(CertificateRequest certificateRequest)
	{
	}

	protected virtual void SendCertificateStatusMessage(CertificateStatus certificateStatus)
	{
	}

	protected virtual void SendHelloRequestMessage()
	{
	}

	protected virtual void SendNewSessionTicketMessage(NewSessionTicket newSessionTicket)
	{
	}

	protected virtual void SendServerHelloDoneMessage()
	{
	}

	protected virtual void SendServerHelloMessage(ServerHello serverHello)
	{
	}

	protected virtual void SendServerKeyExchangeMessage(byte[] serverKeyExchange)
	{
	}

	protected virtual void Skip13ClientCertificate()
	{
	}

	protected virtual void Skip13ClientCertificateVerify()
	{
	}
}
