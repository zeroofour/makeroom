using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Frodo;

public class FrodoKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private FrodoParameters m_parameters;

	private SecureRandom m_random;

	public void Init(KeyGenerationParameters param)
	{
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}
}
