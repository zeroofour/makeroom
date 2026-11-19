using System.Collections.Generic;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public sealed class SecurityParameters
{
	internal int m_entity;

	internal bool m_resumedSession;

	internal bool m_secureRenegotiation;

	internal int m_cipherSuite;

	internal short m_maxFragmentLength;

	internal int m_prfAlgorithm;

	internal int m_prfCryptoHashAlgorithm;

	internal int m_prfHashLength;

	internal int m_verifyDataLength;

	internal TlsSecret m_baseKeyClient;

	internal TlsSecret m_baseKeyServer;

	internal TlsSecret m_earlyExporterMasterSecret;

	internal TlsSecret m_earlySecret;

	internal TlsSecret m_exporterMasterSecret;

	internal TlsSecret m_handshakeSecret;

	internal TlsSecret m_masterSecret;

	internal TlsSecret m_trafficSecretClient;

	internal TlsSecret m_trafficSecretServer;

	internal byte[] m_clientRandom;

	internal byte[] m_serverRandom;

	internal byte[] m_sessionHash;

	internal byte[] m_sessionID;

	internal byte[] m_pskIdentity;

	internal byte[] m_srpIdentity;

	internal byte[] m_tlsServerEndPoint;

	internal byte[] m_tlsUnique;

	internal bool m_encryptThenMac;

	internal bool m_extendedMasterSecret;

	internal bool m_extendedPadding;

	internal bool m_truncatedHmac;

	internal ProtocolName m_applicationProtocol;

	internal bool m_applicationProtocolSet;

	internal short[] m_clientCertTypes;

	internal IList<ServerName> m_clientServerNames;

	internal IList<SignatureAndHashAlgorithm> m_clientSigAlgs;

	internal IList<SignatureAndHashAlgorithm> m_clientSigAlgsCert;

	internal int[] m_clientSupportedGroups;

	internal IList<SignatureAndHashAlgorithm> m_serverSigAlgs;

	internal IList<SignatureAndHashAlgorithm> m_serverSigAlgsCert;

	internal int[] m_serverSupportedGroups;

	internal int m_keyExchangeAlgorithm;

	internal Certificate m_localCertificate;

	internal Certificate m_peerCertificate;

	internal ProtocolVersion m_negotiatedVersion;

	internal int m_statusRequestVersion;

	internal short m_clientCertificateType;

	internal short m_serverCertificateType;

	internal byte[] m_localVerifyData;

	internal byte[] m_peerVerifyData;

	internal byte[] m_connectionIDLocal;

	internal byte[] m_connectionIDPeer;

	public ProtocolName ApplicationProtocol => null;

	public TlsSecret BaseKeyClient => null;

	public TlsSecret BaseKeyServer => null;

	public int CipherSuite => 0;

	public short ClientCertificateType => 0;

	public short[] ClientCertTypes => null;

	public byte[] ClientRandom => null;

	public IList<ServerName> ClientServerNames => null;

	public IList<SignatureAndHashAlgorithm> ClientSigAlgs => null;

	public IList<SignatureAndHashAlgorithm> ClientSigAlgsCert => null;

	public int[] ClientSupportedGroups => null;

	public byte[] ConnectionIDLocal => null;

	public byte[] ConnectionIDPeer => null;

	public TlsSecret EarlyExporterMasterSecret => null;

	public TlsSecret EarlySecret => null;

	public TlsSecret ExporterMasterSecret => null;

	public int Entity => 0;

	public TlsSecret HandshakeSecret => null;

	public bool IsApplicationProtocolSet => false;

	public bool IsEncryptThenMac => false;

	public bool IsExtendedMasterSecret => false;

	public bool IsExtendedPadding => false;

	public bool IsResumedSession => false;

	public bool IsSecureRenegotiation => false;

	public bool IsTruncatedHmac => false;

	public int KeyExchangeAlgorithm => 0;

	public Certificate LocalCertificate => null;

	public byte[] LocalVerifyData => null;

	public TlsSecret MasterSecret => null;

	public short MaxFragmentLength => 0;

	public ProtocolVersion NegotiatedVersion => null;

	public Certificate PeerCertificate => null;

	public byte[] PeerVerifyData => null;

	public int PrfAlgorithm => 0;

	public int PrfCryptoHashAlgorithm => 0;

	public int PrfHashLength => 0;

	public byte[] PskIdentity => null;

	public short ServerCertificateType => 0;

	public byte[] ServerRandom => null;

	public IList<SignatureAndHashAlgorithm> ServerSigAlgs => null;

	public IList<SignatureAndHashAlgorithm> ServerSigAlgsCert => null;

	public int[] ServerSupportedGroups => null;

	public byte[] SessionHash => null;

	public byte[] SessionID => null;

	public byte[] SrpIdentity => null;

	public int StatusRequestVersion => 0;

	public byte[] TlsServerEndPoint => null;

	public byte[] TlsUnique => null;

	public TlsSecret TrafficSecretClient => null;

	public TlsSecret TrafficSecretServer => null;

	public int VerifyDataLength => 0;

	internal void Clear()
	{
	}

	private static TlsSecret ClearSecret(TlsSecret secret)
	{
		return null;
	}
}
