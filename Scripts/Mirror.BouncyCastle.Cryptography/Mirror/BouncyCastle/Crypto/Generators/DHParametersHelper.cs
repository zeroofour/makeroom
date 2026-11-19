using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Generators;

internal class DHParametersHelper
{
	private static readonly int[][] primeLists;

	private static readonly int[] primeProducts;

	private static readonly BigInteger[] BigPrimeProducts;

	internal static BigInteger[] GenerateSafePrimes(int size, int certainty, SecureRandom random)
	{
		return null;
	}

	internal static BigInteger SelectGenerator(BigInteger p, BigInteger q, SecureRandom random)
	{
		return null;
	}
}
