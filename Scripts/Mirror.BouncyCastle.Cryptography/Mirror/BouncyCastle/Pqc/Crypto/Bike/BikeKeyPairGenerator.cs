using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Bike;

public sealed class BikeKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private SecureRandom random;

	private int r;

	private int l;

	private int L_BYTE;

	private int R_BYTE;

	private BikeKeyGenerationParameters bikeKeyGenerationParameters;

	public void Init(KeyGenerationParameters param)
	{
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}
}
