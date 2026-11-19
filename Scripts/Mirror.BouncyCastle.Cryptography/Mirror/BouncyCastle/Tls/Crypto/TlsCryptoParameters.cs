namespace Mirror.BouncyCastle.Tls.Crypto;

public class TlsCryptoParameters
{
	private readonly TlsContext m_context;

	public SecurityParameters SecurityParameters => null;

	public ProtocolVersion ClientVersion => null;

	public ProtocolVersion RsaPreMasterSecretVersion => null;

	public virtual ProtocolVersion ServerVersion => null;

	public bool IsServer => false;

	public TlsNonceGenerator NonceGenerator => null;

	public TlsCryptoParameters(TlsContext context)
	{
	}
}
