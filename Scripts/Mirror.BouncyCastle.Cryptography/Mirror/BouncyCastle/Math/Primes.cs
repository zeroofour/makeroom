using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Math;

public static class Primes
{
	public sealed class MROutput
	{
		private readonly bool m_provablyComposite;

		private readonly BigInteger m_factor;

		public BigInteger Factor => null;

		public bool IsProvablyComposite => false;

		public bool IsNotPrimePower => false;

		internal static MROutput ProbablyPrime()
		{
			return null;
		}

		internal static MROutput ProvablyCompositeWithFactor(BigInteger factor)
		{
			return null;
		}

		internal static MROutput ProvablyCompositeNotPrimePower()
		{
			return null;
		}

		private MROutput(bool provablyComposite, BigInteger factor)
		{
		}
	}

	public sealed class STOutput
	{
		private readonly BigInteger m_prime;

		private readonly byte[] m_primeSeed;

		private readonly int m_primeGenCounter;

		public BigInteger Prime => null;

		public byte[] PrimeSeed => null;

		public int PrimeGenCounter => 0;

		internal STOutput(BigInteger prime, byte[] primeSeed, int primeGenCounter)
		{
		}
	}

	public static readonly int SmallFactorLimit;

	private static readonly BigInteger One;

	private static readonly BigInteger Two;

	private static readonly BigInteger Three;

	public static STOutput GenerateSTRandomPrime(IDigest hash, int length, byte[] inputSeed)
	{
		return null;
	}

	public static MROutput EnhancedMRProbablePrimeTest(BigInteger candidate, SecureRandom random, int iterations)
	{
		return null;
	}

	public static bool HasAnySmallFactors(BigInteger candidate)
	{
		return false;
	}

	public static bool IsMRProbablePrime(BigInteger candidate, SecureRandom random, int iterations)
	{
		return false;
	}

	public static bool IsMRProbablePrimeToBase(BigInteger candidate, BigInteger baseValue)
	{
		return false;
	}

	private static void CheckCandidate(BigInteger n, string name)
	{
	}

	private static bool ImplHasAnySmallFactors(BigInteger x)
	{
		return false;
	}

	private static bool ImplMRProbablePrimeToBase(BigInteger w, BigInteger wSubOne, BigInteger m, int a, BigInteger b)
	{
		return false;
	}

	private static STOutput ImplSTRandomPrime(IDigest d, int length, byte[] primeSeed)
	{
		return null;
	}

	private static void Hash(IDigest d, byte[] input, byte[] output, int outPos)
	{
	}

	private static BigInteger HashGen(IDigest d, byte[] seed, int count)
	{
		return null;
	}

	private static void Inc(byte[] seed, int c)
	{
	}

	private static bool IsPrime32(uint x)
	{
		return false;
	}
}
