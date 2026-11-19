using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Crypto.Generators;

public class DHKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private DHKeyGenerationParameters m_parameters;

	public virtual void Init(KeyGenerationParameters parameters)
	{
	}

	public virtual AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}
}
