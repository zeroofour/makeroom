using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Kyber;

public class KyberKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private KyberParameters KyberParams;

	private SecureRandom random;

	private void Initialize(KeyGenerationParameters param)
	{
	}

	private AsymmetricCipherKeyPair GenKeyPair()
	{
		return null;
	}

	public void Init(KeyGenerationParameters param)
	{
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}
}
