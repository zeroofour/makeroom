using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Hqc;

public class HqcKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private int n;

	private int k;

	private int delta;

	private int w;

	private int wr;

	private int we;

	private int N_BYTE;

	private HqcKeyGenerationParameters hqcKeyGenerationParameters;

	private SecureRandom random;

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}

	public AsymmetricCipherKeyPair GenerateKeyPairWithSeed(byte[] seed)
	{
		return null;
	}

	public void Init(KeyGenerationParameters parameters)
	{
	}

	private AsymmetricCipherKeyPair GenKeyPair(byte[] seed)
	{
		return null;
	}
}
