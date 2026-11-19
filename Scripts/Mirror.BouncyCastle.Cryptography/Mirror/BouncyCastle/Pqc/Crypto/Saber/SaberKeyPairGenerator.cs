using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Saber;

public class SaberKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private SaberKeyGenerationParameters saberParams;

	private int l;

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
