using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP160R1Field
{
	internal static readonly uint[] P;

	private static readonly uint[] PExt;

	private static readonly uint[] PExtInv;

	private const uint P4 = uint.MaxValue;

	private const uint PExt9 = uint.MaxValue;

	private const uint PInv = 2147483649u;

	public static void Add(uint[] x, uint[] y, uint[] z)
	{
	}

	public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
	{
	}

	public static void AddOne(uint[] x, uint[] z)
	{
	}

	public static uint[] FromBigInteger(BigInteger x)
	{
		return null;
	}

	public static void Half(uint[] x, uint[] z)
	{
	}

	public static void Inv(uint[] x, uint[] z)
	{
	}

	public static int IsZero(uint[] x)
	{
		return 0;
	}

	public static void Multiply(uint[] x, uint[] y, uint[] z)
	{
	}

	public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
	{
	}

	public static void Negate(uint[] x, uint[] z)
	{
	}

	public static void Random(SecureRandom r, uint[] z)
	{
	}

	public static void RandomMult(SecureRandom r, uint[] z)
	{
	}

	public static void Reduce(uint[] xx, uint[] z)
	{
	}

	public static void Reduce32(uint x, uint[] z)
	{
	}

	public static void Square(uint[] x, uint[] z)
	{
	}

	public static void SquareN(uint[] x, int n, uint[] z)
	{
	}

	public static void Subtract(uint[] x, uint[] y, uint[] z)
	{
	}

	public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
	{
	}

	public static void Twice(uint[] x, uint[] z)
	{
	}
}
