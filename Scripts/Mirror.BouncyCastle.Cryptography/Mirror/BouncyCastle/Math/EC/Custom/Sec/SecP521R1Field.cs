using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP521R1Field
{
	internal static readonly uint[] P;

	private const uint P16 = 511u;

	public static void Add(uint[] x, uint[] y, uint[] z)
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

	public static void Multiply(uint[] x, uint[] y, uint[] z, uint[] tt)
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

	public static void Reduce23(uint[] z)
	{
	}

	public static void Square(uint[] x, uint[] z)
	{
	}

	public static void Square(uint[] x, uint[] z, uint[] tt)
	{
	}

	public static void SquareN(uint[] x, int n, uint[] z)
	{
	}

	public static void SquareN(uint[] x, int n, uint[] z, uint[] tt)
	{
	}

	public static void Subtract(uint[] x, uint[] y, uint[] z)
	{
	}

	public static void Twice(uint[] x, uint[] z)
	{
	}

	protected static void ImplMultiply(uint[] x, uint[] y, uint[] zz)
	{
	}

	protected static void ImplSquare(uint[] x, uint[] zz)
	{
	}
}
