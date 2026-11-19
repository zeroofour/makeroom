using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Utilities;

public static class BigIntegers
{
	public static readonly BigInteger Zero;

	public static readonly BigInteger One;

	private const int MaxIterations = 1000;

	public static byte[] AsUnsignedByteArray(BigInteger n)
	{
		return null;
	}

	public static byte[] AsUnsignedByteArray(int length, BigInteger n)
	{
		return null;
	}

	public static void AsUnsignedByteArray(BigInteger n, byte[] buf, int off, int len)
	{
	}

	public static BigInteger CreateRandomBigInteger(int bitLength, SecureRandom secureRandom)
	{
		return null;
	}

	public static BigInteger CreateRandomInRange(BigInteger min, BigInteger max, SecureRandom random)
	{
		return null;
	}

	public static BigInteger FromUnsignedByteArray(byte[] buf)
	{
		return null;
	}

	public static BigInteger FromUnsignedByteArray(byte[] buf, int off, int length)
	{
		return null;
	}

	public static int GetByteLength(BigInteger n)
	{
		return 0;
	}

	public static int GetUnsignedByteLength(BigInteger n)
	{
		return 0;
	}

	public static BigInteger ModOddInverse(BigInteger M, BigInteger X)
	{
		return null;
	}

	public static BigInteger ModOddInverseVar(BigInteger M, BigInteger X)
	{
		return null;
	}

	public static bool ModOddIsCoprime(BigInteger M, BigInteger X)
	{
		return false;
	}

	public static bool ModOddIsCoprimeVar(BigInteger M, BigInteger X)
	{
		return false;
	}
}
