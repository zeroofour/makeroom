using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Crypto.Generators;

public class Gost3410KeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private Gost3410KeyGenerationParameters param;

	public void Init(KeyGenerationParameters parameters)
	{
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}
}
