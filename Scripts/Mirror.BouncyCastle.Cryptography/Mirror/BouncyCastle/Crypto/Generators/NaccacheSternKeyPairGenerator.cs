using System.Collections.Generic;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Generators;

public class NaccacheSternKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private static readonly int[] smallPrimes;

	private NaccacheSternKeyGenerationParameters param;

	public void Init(KeyGenerationParameters parameters)
	{
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}

	private static BigInteger GeneratePrime(int bitLength, int certainty, SecureRandom rand)
	{
		return null;
	}

	private static IList<T> PermuteList<T>(IList<T> arr, SecureRandom rand)
	{
		return null;
	}

	private static IList<BigInteger> FindFirstPrimes(int count)
	{
		return null;
	}
}
