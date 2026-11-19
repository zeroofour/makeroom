namespace Mirror.BouncyCastle.Math.EC.Custom.Sec;

internal static class SecT571Field
{
	private const ulong M59 = 576460752303423487uL;

	private static readonly ulong[] ROOT_Z;

	public static void Add(ulong[] x, ulong[] y, ulong[] z)
	{
	}

	private static void Add(ulong[] x, int xOff, ulong[] y, int yOff, ulong[] z, int zOff)
	{
	}

	public static void AddBothTo(ulong[] x, ulong[] y, ulong[] z)
	{
	}

	private static void AddBothTo(ulong[] x, int xOff, ulong[] y, int yOff, ulong[] z, int zOff)
	{
	}

	public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
	{
	}

	public static void AddOne(ulong[] x, ulong[] z)
	{
	}

	public static void AddTo(ulong[] x, ulong[] z)
	{
	}

	public static ulong[] FromBigInteger(BigInteger x)
	{
		return null;
	}

	public static void HalfTrace(ulong[] x, ulong[] z)
	{
	}

	public static void Invert(ulong[] x, ulong[] z)
	{
	}

	public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
	{
	}

	public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
	{
	}

	public static void MultiplyExt(ulong[] x, ulong[] y, ulong[] zz)
	{
	}

	public static void MultiplyPrecomp(ulong[] x, ulong[] precomp, ulong[] z)
	{
	}

	public static void MultiplyPrecompAddToExt(ulong[] x, ulong[] precomp, ulong[] zz)
	{
	}

	public static ulong[] PrecompMultiplicand(ulong[] x)
	{
		return null;
	}

	public static void Reduce(ulong[] xx, ulong[] z)
	{
	}

	public static void Reduce5(ulong[] z, int zOff)
	{
	}

	public static void Sqrt(ulong[] x, ulong[] z)
	{
	}

	public static void Square(ulong[] x, ulong[] z)
	{
	}

	public static void SquareAddToExt(ulong[] x, ulong[] zz)
	{
	}

	public static void SquareExt(ulong[] x, ulong[] zz)
	{
	}

	public static void SquareN(ulong[] x, int n, ulong[] z)
	{
	}

	public static uint Trace(ulong[] x)
	{
		return 0u;
	}

	private static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
	{
	}

	private static void ImplMultiplyPrecomp(ulong[] x, ulong[] precomp, ulong[] zz)
	{
	}

	private static void ImplMulwAcc(ulong[] u, ulong x, ulong y, ulong[] z, int zOff)
	{
	}

	private static void ImplSquare(ulong[] x, ulong[] zz)
	{
	}
}
