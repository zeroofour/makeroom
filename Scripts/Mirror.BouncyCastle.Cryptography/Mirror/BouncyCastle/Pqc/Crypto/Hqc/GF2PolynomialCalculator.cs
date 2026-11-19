namespace Mirror.BouncyCastle.Pqc.Crypto.Hqc;

internal class GF2PolynomialCalculator
{
	private readonly int _vecNSize64;

	private readonly int _paramN;

	private readonly long _redMask;

	public GF2PolynomialCalculator(int vecNSize64, int paramN, ulong redMask)
	{
	}

	internal void MultLongs(long[] res, long[] a, long[] b)
	{
	}

	private void base_mul(long[] c, int cOffset, long a, long b)
	{
	}

	private void karatsuba_add1(long[] alh, int alhOffset, long[] blh, int blhOffset, long[] a, int aOffset, long[] b, int bOffset, int size_l, int size_h)
	{
	}

	private void karatsuba_add2(long[] o, int oOffset, long[] tmp1, int tmp1Offset, long[] tmp2, int tmp2Offset, int size_l, int size_h)
	{
	}

	private void karatsuba(long[] o, int oOffset, long[] a, int aOffset, long[] b, int bOffset, int size, long[] stack, int stackOffset)
	{
	}

	private void reduce(long[] o, long[] a)
	{
	}

	internal static void AddLongs(long[] res, long[] a, long[] b)
	{
	}
}
