using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Crypto.Generators;

public class ElGamalKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private ElGamalKeyGenerationParameters m_parameters;

	public void Init(KeyGenerationParameters parameters)
	{
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}
}
