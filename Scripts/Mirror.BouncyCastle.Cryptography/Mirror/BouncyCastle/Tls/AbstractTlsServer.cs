using System.Collections.Generic;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public abstract class AbstractTlsServer : AbstractTlsPeer, TlsServer, TlsPeer
{
	protected TlsServerContext m_context;

	protected ProtocolVersion[] m_protocolVersions;

	protected int[] m_cipherSuites;

	protected int[] m_offeredCipherSuites;

	protected IDictionary<int, byte[]> m_clientExtensions;

	protected bool m_encryptThenMACOffered;

	protected short m_maxFragmentLengthOffered;

	protected bool m_truncatedHMacOffered;

	protected bool m_clientSentECPointFormats;

	protected CertificateStatusRequest m_certificateStatusRequest;

	protected IList<CertificateStatusRequestItemV2> m_statusRequestV2;

	protected IList<TrustedAuthority> m_trustedCAKeys;

	protected int m_selectedCipherSuite;

	protected IList<ProtocolName> m_clientProtocolNames;

	protected ProtocolName m_selectedProtocolName;

	protected readonly IDictionary<int, byte[]> m_serverExtensions;

	public AbstractTlsServer(TlsCrypto crypto)
		: base(null)
	{
	}

	protected virtual bool AllowCertificateStatus()
	{
		return false;
	}

	protected virtual bool AllowEncryptThenMac()
	{
		return false;
	}

	protected virtual bool AllowMultiCertStatus()
	{
		return false;
	}

	protected virtual bool AllowTruncatedHmac()
	{
		return false;
	}

	protected virtual bool AllowTrustedCAIndication()
	{
		return false;
	}

	protected virtual string GetDetailMessageNoCipherSuite()
	{
		return null;
	}

	protected virtual int GetMaximumNegotiableCurveBits()
	{
		return 0;
	}

	protected virtual int GetMaximumNegotiableFiniteFieldBits()
	{
		return 0;
	}

	protected virtual IList<ProtocolName> GetProtocolNames()
	{
		return null;
	}

	protected virtual bool IsSelectableCipherSuite(int cipherSuite, int availCurveBits, int availFiniteFieldBits, IList<short> sigAlgs)
	{
		return false;
	}

	protected virtual bool PreferLocalCipherSuites()
	{
		return false;
	}

	protected virtual bool SelectCipherSuite(int cipherSuite)
	{
		return false;
	}

	protected virtual int SelectDH(int minimumFiniteFieldBits)
	{
		return 0;
	}

	protected virtual int SelectDHDefault(int minimumFiniteFieldBits)
	{
		return 0;
	}

	protected virtual int SelectECDH(int minimumCurveBits)
	{
		return 0;
	}

	protected virtual int SelectECDHDefault(int minimumCurveBits)
	{
		return 0;
	}

	protected virtual ProtocolName SelectProtocolName()
	{
		return null;
	}

	protected virtual ProtocolName SelectProtocolName(IList<ProtocolName> clientProtocolNames, IList<ProtocolName> serverProtocolNames)
	{
		return null;
	}

	protected virtual bool ShouldSelectProtocolNameEarly()
	{
		return false;
	}

	protected virtual bool PreferLocalClientCertificateTypes()
	{
		return false;
	}

	protected virtual short[] GetAllowedClientCertificateTypes()
	{
		return null;
	}

	protected virtual byte[] GetNewConnectionID()
	{
		return null;
	}

	public virtual void Init(TlsServerContext context)
	{
	}

	public override ProtocolVersion[] GetProtocolVersions()
	{
		return null;
	}

	public override int[] GetCipherSuites()
	{
		return null;
	}

	public override void NotifyHandshakeBeginning()
	{
	}

	public virtual TlsSession GetSessionToResume(byte[] sessionID)
	{
		return null;
	}

	public virtual byte[] GetNewSessionID()
	{
		return null;
	}

	public virtual TlsPskExternal GetExternalPsk(IList<PskIdentity> identities)
	{
		return null;
	}

	public virtual void NotifySession(TlsSession session)
	{
	}

	public virtual void NotifyClientVersion(ProtocolVersion clientVersion)
	{
	}

	public virtual void NotifyFallback(bool isFallback)
	{
	}

	public virtual void NotifyOfferedCipherSuites(int[] offeredCipherSuites)
	{
	}

	public virtual void ProcessClientExtensions(IDictionary<int, byte[]> clientExtensions)
	{
	}

	public virtual ProtocolVersion GetServerVersion()
	{
		return null;
	}

	public virtual int[] GetSupportedGroups()
	{
		return null;
	}

	public virtual int GetSelectedCipherSuite()
	{
		return 0;
	}

	public virtual IDictionary<int, byte[]> GetServerExtensions()
	{
		return null;
	}

	public virtual void GetServerExtensionsForConnection(IDictionary<int, byte[]> serverExtensions)
	{
	}

	public virtual IList<SupplementalDataEntry> GetServerSupplementalData()
	{
		return null;
	}

	public abstract TlsCredentials GetCredentials();

	public virtual CertificateStatus GetCertificateStatus()
	{
		return null;
	}

	public virtual CertificateRequest GetCertificateRequest()
	{
		return null;
	}

	public virtual TlsPskIdentityManager GetPskIdentityManager()
	{
		return null;
	}

	public virtual TlsSrpLoginParameters GetSrpLoginParameters()
	{
		return null;
	}

	public virtual TlsDHConfig GetDHConfig()
	{
		return null;
	}

	public virtual TlsECConfig GetECDHConfig()
	{
		return null;
	}

	public virtual void ProcessClientSupplementalData(IList<SupplementalDataEntry> clientSupplementalData)
	{
	}

	public virtual void NotifyClientCertificate(Certificate clientCertificate)
	{
	}

	public virtual NewSessionTicket GetNewSessionTicket()
	{
		return null;
	}
}
