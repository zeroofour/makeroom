using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public sealed class LmsKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private LmsKeyGenerationParameters m_parameters;

	public void Init(KeyGenerationParameters parameters)
	{
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}
}
