using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

internal abstract class AbstractTlsContext : TlsContext
{
	private static long counter;

	private readonly TlsCrypto m_crypto;

	private readonly int m_connectionEnd;

	private readonly TlsNonceGenerator m_nonceGenerator;

	private SecurityParameters m_securityParameters;

	private ProtocolVersion[] m_clientSupportedVersions;

	private ProtocolVersion m_clientVersion;

	private ProtocolVersion m_rsaPreMasterSecretVersion;

	private TlsSession m_session;

	private object m_userObject;

	private bool m_connected;

	internal bool IsConnected => false;

	internal bool IsHandshaking => false;

	public TlsCrypto Crypto => null;

	public virtual TlsNonceGenerator NonceGenerator => null;

	public SecurityParameters SecurityParameters => null;

	public abstract bool IsServer { get; }

	public virtual ProtocolVersion[] ClientSupportedVersions => null;

	public virtual ProtocolVersion ClientVersion => null;

	public virtual ProtocolVersion RsaPreMasterSecretVersion => null;

	public virtual ProtocolVersion ServerVersion => null;

	public virtual TlsSession ResumableSession => null;

	public virtual TlsSession Session => null;

	public virtual object UserObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private static long NextCounterValue()
	{
		return 0L;
	}

	private static TlsNonceGenerator CreateNonceGenerator(TlsCrypto crypto, int connectionEnd)
	{
		return null;
	}

	internal AbstractTlsContext(TlsCrypto crypto, int connectionEnd)
	{
	}

	internal void HandshakeBeginning(TlsPeer peer)
	{
	}

	internal void HandshakeComplete(TlsPeer peer, TlsSession session)
	{
	}

	internal void SetClientSupportedVersions(ProtocolVersion[] clientSupportedVersions)
	{
	}

	internal void SetClientVersion(ProtocolVersion clientVersion)
	{
	}

	internal void SetRsaPreMasterSecretVersion(ProtocolVersion rsaPreMasterSecretVersion)
	{
	}

	public virtual byte[] ExportChannelBinding(int channelBinding)
	{
		return null;
	}

	public virtual byte[] ExportEarlyKeyingMaterial(string asciiLabel, byte[] context, int length)
	{
		return null;
	}

	public virtual byte[] ExportKeyingMaterial(string asciiLabel, byte[] context, int length)
	{
		return null;
	}

	protected virtual byte[] ExportKeyingMaterial13(TlsSecret secret, int cryptoHashAlgorithm, string asciiLabel, byte[] context, int length)
	{
		return null;
	}

	protected virtual TlsSecret CheckEarlyExportSecret(TlsSecret secret)
	{
		return null;
	}

	protected virtual TlsSecret CheckExportSecret(TlsSecret secret)
	{
		return null;
	}
}
