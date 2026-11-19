using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public abstract class AbstractTlsClient : AbstractTlsPeer, TlsClient, TlsPeer
{
	protected TlsClientContext m_context;

	protected ProtocolVersion[] m_protocolVersions;

	protected int[] m_cipherSuites;

	protected IList<int> m_supportedGroups;

	protected IList<SignatureAndHashAlgorithm> m_supportedSignatureAlgorithms;

	protected IList<SignatureAndHashAlgorithm> m_supportedSignatureAlgorithmsCert;

	protected AbstractTlsClient(TlsCrypto crypto)
		: base(null)
	{
	}

	protected virtual bool AllowUnexpectedServerExtension(int extensionType, byte[] extensionData)
	{
		return false;
	}

	protected virtual IList<int> GetNamedGroupRoles()
	{
		return null;
	}

	protected virtual void CheckForUnexpectedServerExtension(IDictionary<int, byte[]> serverExtensions, int extensionType)
	{
	}

	protected virtual byte[] GetNewConnectionID()
	{
		return null;
	}

	public virtual TlsPskIdentity GetPskIdentity()
	{
		return null;
	}

	public virtual TlsSrpIdentity GetSrpIdentity()
	{
		return null;
	}

	public virtual TlsDHGroupVerifier GetDHGroupVerifier()
	{
		return null;
	}

	public virtual TlsSrpConfigVerifier GetSrpConfigVerifier()
	{
		return null;
	}

	protected virtual IList<X509Name> GetCertificateAuthorities()
	{
		return null;
	}

	protected virtual IList<ProtocolName> GetProtocolNames()
	{
		return null;
	}

	protected virtual CertificateStatusRequest GetCertificateStatusRequest()
	{
		return null;
	}

	protected virtual IList<CertificateStatusRequestItemV2> GetMultiCertStatusRequest()
	{
		return null;
	}

	protected virtual IList<ServerName> GetSniServerNames()
	{
		return null;
	}

	protected virtual IList<int> GetSupportedGroups(IList<int> namedGroupRoles)
	{
		return null;
	}

	protected virtual IList<SignatureAndHashAlgorithm> GetSupportedSignatureAlgorithms()
	{
		return null;
	}

	protected virtual IList<SignatureAndHashAlgorithm> GetSupportedSignatureAlgorithmsCert()
	{
		return null;
	}

	protected virtual IList<TrustedAuthority> GetTrustedCAIndication()
	{
		return null;
	}

	protected virtual short[] GetAllowedClientCertificateTypes()
	{
		return null;
	}

	protected virtual short[] GetAllowedServerCertificateTypes()
	{
		return null;
	}

	public virtual void Init(TlsClientContext context)
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

	public virtual TlsSession GetSessionToResume()
	{
		return null;
	}

	public virtual IList<TlsPskExternal> GetExternalPsks()
	{
		return null;
	}

	public virtual bool IsFallback()
	{
		return false;
	}

	public virtual IDictionary<int, byte[]> GetClientExtensions()
	{
		return null;
	}

	public virtual IList<int> GetEarlyKeyShareGroups()
	{
		return null;
	}

	public virtual bool ShouldUseCompatibilityMode()
	{
		return false;
	}

	public virtual void NotifyServerVersion(ProtocolVersion serverVersion)
	{
	}

	public virtual void NotifySessionToResume(TlsSession session)
	{
	}

	public virtual void NotifySessionID(byte[] sessionID)
	{
	}

	public virtual void NotifySelectedCipherSuite(int selectedCipherSuite)
	{
	}

	public virtual void NotifySelectedPsk(TlsPsk selectedPsk)
	{
	}

	public virtual void ProcessServerExtensions(IDictionary<int, byte[]> serverExtensions)
	{
	}

	public virtual void ProcessServerSupplementalData(IList<SupplementalDataEntry> serverSupplementalData)
	{
	}

	public abstract TlsAuthentication GetAuthentication();

	public virtual IList<SupplementalDataEntry> GetClientSupplementalData()
	{
		return null;
	}

	public virtual void NotifyNewSessionTicket(NewSessionTicket newSessionTicket)
	{
	}
}
