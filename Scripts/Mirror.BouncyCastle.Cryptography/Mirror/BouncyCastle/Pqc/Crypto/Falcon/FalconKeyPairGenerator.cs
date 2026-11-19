using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Falcon;

public class FalconKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private FalconKeyGenerationParameters parameters;

	private SecureRandom random;

	private FalconNist nist;

	private uint logn;

	private uint noncelen;

	private int pk_size;

	public void Init(KeyGenerationParameters param)
	{
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}
}
