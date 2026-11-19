using Mirror.BouncyCastle.Crypto.Prng;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

internal sealed class BcTlsNonceGenerator : TlsNonceGenerator
{
	private readonly IRandomGenerator m_randomGenerator;

	internal BcTlsNonceGenerator(IRandomGenerator randomGenerator)
	{
	}

	public byte[] GenerateNonce(int size)
	{
		return null;
	}
}
