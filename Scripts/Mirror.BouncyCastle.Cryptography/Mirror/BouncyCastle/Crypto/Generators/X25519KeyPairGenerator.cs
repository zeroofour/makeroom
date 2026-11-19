using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Generators;

public class X25519KeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private SecureRandom random;

	public virtual void Init(KeyGenerationParameters parameters)
	{
	}

	public virtual AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}
}
