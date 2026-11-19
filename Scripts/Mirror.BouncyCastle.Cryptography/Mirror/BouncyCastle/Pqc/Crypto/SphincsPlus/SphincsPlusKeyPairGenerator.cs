using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

public sealed class SphincsPlusKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private SecureRandom random;

	private SphincsPlusParameters parameters;

	public void Init(KeyGenerationParameters param)
	{
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}

	private byte[] SecRand(int n)
	{
		return null;
	}
}
