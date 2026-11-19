using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class PskTlsClient : AbstractTlsClient
{
	private static readonly int[] DefaultCipherSuites;

	protected readonly TlsPskIdentity m_pskIdentity;

	public PskTlsClient(TlsCrypto crypto, byte[] identity, byte[] psk)
		: base(null)
	{
	}

	public PskTlsClient(TlsCrypto crypto, TlsPskIdentity pskIdentity)
		: base(null)
	{
	}

	protected override ProtocolVersion[] GetSupportedVersions()
	{
		return null;
	}

	protected override int[] GetSupportedCipherSuites()
	{
		return null;
	}

	public override TlsPskIdentity GetPskIdentity()
	{
		return null;
	}

	public override TlsAuthentication GetAuthentication()
	{
		return null;
	}
}
