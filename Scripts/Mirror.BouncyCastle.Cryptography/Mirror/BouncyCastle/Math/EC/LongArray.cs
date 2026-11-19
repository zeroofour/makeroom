namespace Mirror.BouncyCastle.Math.EC;

internal struct LongArray
{
	private ulong[] m_data = null;

	internal static bool AreAliased(ref LongArray a, ref LongArray b)
	{
		return false;
	}

	internal LongArray(int intLen)
	{
	}

	internal LongArray(ulong[] data)
	{
	}

	internal LongArray(ulong[] data, int off, int len)
	{
	}

	internal LongArray(BigInteger bigInt)
	{
	}

	internal void CopyTo(ulong[] z, int zOff)
	{
	}

	internal bool IsOne()
	{
		return false;
	}

	internal bool IsZero()
	{
		return false;
	}

	internal int GetUsedLength()
	{
		return 0;
	}

	internal int GetUsedLengthFrom(int from)
	{
		return 0;
	}

	internal int Degree()
	{
		return 0;
	}

	private int DegreeFrom(int limit)
	{
		return 0;
	}

	private static int BitLength(ulong w)
	{
		return 0;
	}

	private ulong[] ResizedData(int newLen)
	{
		return null;
	}

	internal BigInteger ToBigInteger()
	{
		return null;
	}

	private static ulong ShiftUp(ulong[] x, int xOff, int count, int shift)
	{
		return 0uL;
	}

	private static ulong ShiftUp(ulong[] x, int xOff, ulong[] z, int zOff, int count, int shift)
	{
		return 0uL;
	}

	internal LongArray AddOne()
	{
		return default;
	}

	private void AddShiftedByBitsSafe(LongArray other, int otherDegree, int bits)
	{
	}

	private static ulong AddShiftedUp(ulong[] x, int xOff, ulong[] y, int yOff, int count, int shift)
	{
		return 0uL;
	}

	private static ulong AddShiftedDown(ulong[] x, int xOff, ulong[] y, int yOff, int count, int shift)
	{
		return 0uL;
	}

	internal void AddShiftedByWords(LongArray other, int words)
	{
	}

	private static void Add(ulong[] x, int xOff, ulong[] y, int yOff, int count)
	{
	}

	private static void Add(ulong[] x, int xOff, ulong[] y, int yOff, ulong[] z, int zOff, int count)
	{
	}

	private static void AddBoth(ulong[] x, int xOff, ulong[] y1, int y1Off, ulong[] y2, int y2Off, int count)
	{
	}

	private static void FlipWord(ulong[] buf, int off, int bit, ulong word)
	{
	}

	internal bool TestBitZero()
	{
		return false;
	}

	private static bool TestBit(ulong[] buf, int off, int n)
	{
		return false;
	}

	private static void FlipBit(ulong[] buf, int off, int n)
	{
	}

	private static void MultiplyWord(ulong a, ulong[] b, int bLen, ulong[] c, int cOff)
	{
	}

	internal LongArray ModMultiplyLD(LongArray other, int m, int[] ks)
	{
		return default;
	}

	internal LongArray ModMultiply(LongArray other, int m, int[] ks)
	{
		return default;
	}

	internal LongArray Multiply(LongArray other, int m, int[] ks)
	{
		return default;
	}

	internal void Reduce(int m, int[] ks)
	{
	}

	private static LongArray ReduceResult(ulong[] buf, int off, int len, int m, int[] ks)
	{
		return default;
	}

	private static int ReduceInPlace(ulong[] buf, int off, int len, int m, int[] ks)
	{
		return 0;
	}

	private static void ReduceBitWise(ulong[] buf, int off, int BitLength, int m, int[] ks)
	{
	}

	private static void ReduceBit(ulong[] buf, int off, int bit, int m, int[] ks)
	{
	}

	private static void ReduceWordWise(ulong[] buf, int off, int len, int toBit, int m, int[] ks)
	{
	}

	private static void ReduceWord(ulong[] buf, int off, int bit, ulong word, int m, int[] ks)
	{
	}

	private static void ReduceVectorWise(ulong[] buf, int off, int len, int words, int m, int[] ks)
	{
	}

	private static void FlipVector(ulong[] x, int xOff, ulong[] y, int yOff, int yLen, int bits)
	{
	}

	internal LongArray ModSquare(int m, int[] ks)
	{
		return default;
	}

	internal LongArray ModSquareN(int n, int m, int[] ks)
	{
		return default;
	}

	internal LongArray Square(int m, int[] ks)
	{
		return default;
	}

	internal LongArray ModInverse(int m, int[] ks)
	{
		return default;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	internal bool Equals(ref LongArray other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public LongArray Copy()
	{
		return default;
	}

	public override string ToString()
	{
		return null;
	}
}
