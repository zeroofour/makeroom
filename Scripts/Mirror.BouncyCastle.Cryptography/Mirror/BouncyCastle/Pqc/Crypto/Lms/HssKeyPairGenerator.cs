using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public sealed class HssKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private HssKeyGenerationParameters m_parameters;

	public void Init(KeyGenerationParameters parameters)
	{
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}
}
