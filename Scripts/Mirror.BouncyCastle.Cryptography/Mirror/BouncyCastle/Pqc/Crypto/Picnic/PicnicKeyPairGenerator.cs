using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Picnic;

public class PicnicKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private SecureRandom random;

	private PicnicParameters parameters;

	public void Init(KeyGenerationParameters param)
	{
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}
}
