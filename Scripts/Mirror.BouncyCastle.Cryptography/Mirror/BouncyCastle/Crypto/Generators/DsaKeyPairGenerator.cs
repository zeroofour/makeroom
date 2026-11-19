using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Generators;

public class DsaKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private static readonly BigInteger One;

	private DsaKeyGenerationParameters param;

	public void Init(KeyGenerationParameters parameters)
	{
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}

	private static BigInteger GeneratePrivateKey(BigInteger q, SecureRandom random)
	{
		return null;
	}

	private static BigInteger CalculatePublicKey(BigInteger p, BigInteger g, BigInteger x)
	{
		return null;
	}
}
