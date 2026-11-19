namespace System.Numerics;

[Serializable]
public readonly struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger>
{
	private enum GetBytesMode
	{
		AllocateArray = 0,
		Count = 1,
		Span = 2
	}

	internal readonly int _sign = 0;

	internal readonly uint[] _bits = null;

	private static readonly BigInteger s_bnMinInt;

	private static readonly BigInteger s_bnOneInt;

	private static readonly BigInteger s_bnZeroInt;

	private static readonly BigInteger s_bnMinusOneInt;

	private static readonly byte[] s_success;

	public static BigInteger MinusOne => default;

	public BigInteger(int value)
	{
	}

	public BigInteger(long value)
	{
	}

	[CLSCompliant(false)]
	public BigInteger(byte[] value)
	{
	}

	public BigInteger(ReadOnlySpan<byte> value, bool isUnsigned = false, bool isBigEndian = false)
	{
	}

	internal BigInteger(int n, uint[] rgu)
	{
	}

	internal BigInteger(uint[] value, bool negative)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(BigInteger other)
	{
		return false;
	}

	public int CompareTo(BigInteger other)
	{
		return 0;
	}

	public int CompareTo(object obj)
	{
		return 0;
	}

	public bool TryWriteBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false)
	{
		bytesWritten = default;
		return false;
	}

	internal bool TryWriteOrCountBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false)
	{
		bytesWritten = default;
		return false;
	}

	private byte[] TryGetBytes(GetBytesMode mode, Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(string format, IFormatProvider provider)
	{
		return null;
	}

	private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign)
	{
		return default;
	}

	private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign)
	{
		return default;
	}

	public static implicit operator BigInteger(byte value)
	{
		return default;
	}

	public static implicit operator BigInteger(int value)
	{
		return default;
	}

	public static implicit operator BigInteger(long value)
	{
		return default;
	}

	public static explicit operator int(BigInteger value)
	{
		return 0;
	}

	public static BigInteger operator <<(BigInteger value, int shift)
	{
		return default;
	}

	public static BigInteger operator >>(BigInteger value, int shift)
	{
		return default;
	}

	public static BigInteger operator +(BigInteger left, BigInteger right)
	{
		return default;
	}

	private static bool GetPartsForBitManipulation(ref BigInteger x, out uint[] xd, out int xl)
	{
		xd = null;
		xl = default;
		return false;
	}

	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu)
	{
		return 0;
	}
}
