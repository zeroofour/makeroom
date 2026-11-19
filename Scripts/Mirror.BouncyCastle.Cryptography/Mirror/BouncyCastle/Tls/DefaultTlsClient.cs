using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public abstract class DefaultTlsClient : AbstractTlsClient
{
	private static readonly int[] DefaultCipherSuites;

	public DefaultTlsClient(TlsCrypto crypto)
		: base(null)
	{
	}

	protected override int[] GetSupportedCipherSuites()
	{
		return null;
	}
}
