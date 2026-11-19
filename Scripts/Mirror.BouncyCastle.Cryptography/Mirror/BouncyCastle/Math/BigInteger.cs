using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Mirror.BouncyCastle.Math;

[Serializable]
public sealed class BigInteger : IComparable, IComparable<BigInteger>, IEquatable<BigInteger>
{
	internal static readonly int[][] primeLists;

	internal static readonly int[] primeProducts;

	private const long IMASK = 4294967295L;

	private const ulong UIMASK = 4294967295uL;

	private static readonly uint[] ZeroMagnitude;

	private static readonly byte[] ZeroEncoding;

	private static readonly BigInteger[] SMALL_CONSTANTS;

	public static readonly BigInteger Zero;

	public static readonly BigInteger One;

	public static readonly BigInteger Two;

	public static readonly BigInteger Three;

	public static readonly BigInteger Four;

	public static readonly BigInteger Five;

	public static readonly BigInteger Six;

	public static readonly BigInteger Ten;

	private static readonly byte[] BitLengthTable;

	private const int chunk2 = 1;

	private const int chunk8 = 1;

	private const int chunk10 = 19;

	private const int chunk16 = 16;

	private static readonly BigInteger radix2;

	private static readonly BigInteger radix2E;

	private static readonly BigInteger radix8;

	private static readonly BigInteger radix8E;

	private static readonly BigInteger radix10;

	private static readonly BigInteger radix10E;

	private static readonly BigInteger radix16;

	private static readonly BigInteger radix16E;

	private static readonly int[] ExpWindowThresholds;

	private const int BitsPerByte = 8;

	private const int BitsPerInt = 32;

	private const int BytesPerInt = 4;

	private readonly uint[] magnitude;

	private readonly int sign;

	[NonSerialized]
	private int nBits;

	[NonSerialized]
	private int nBitLength;

	public int BitCount => 0;

	public int BitLength => 0;

	public int IntValue => 0;

	public int IntValueExact => 0;

	public long LongValue => 0L;

	public long LongValueExact => 0L;

	public int SignValue => 0;

	static BigInteger()
	{
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context)
	{
	}

	private static int GetBytesLength(int nBits)
	{
		return 0;
	}

	public static BigInteger Arbitrary(int sizeInBits)
	{
		return null;
	}

	private BigInteger(int signum, uint[] mag, bool checkMag)
	{
	}

	public BigInteger(string value)
	{
	}

	public BigInteger(string str, int radix)
	{
	}

	public BigInteger(byte[] bytes)
	{
	}

	public BigInteger(byte[] bytes, bool bigEndian)
	{
	}

	public BigInteger(byte[] bytes, int offset, int length)
	{
	}

	public BigInteger(byte[] bytes, int offset, int length, bool bigEndian)
	{
	}

	private static uint[] InitBE(byte[] bytes, int offset, int length, out int sign)
	{
		sign = default;
		return null;
	}

	private static uint[] InitLE(byte[] bytes, int offset, int length, out int sign)
	{
		sign = default;
		return null;
	}

	private static uint[] MakeMagnitudeBE(byte[] bytes)
	{
		return null;
	}

	private static uint[] MakeMagnitudeBE(byte[] bytes, int offset, int length)
	{
		return null;
	}

	private static uint[] MakeMagnitudeLE(byte[] bytes)
	{
		return null;
	}

	private static uint[] MakeMagnitudeLE(byte[] bytes, int offset, int length)
	{
		return null;
	}

	public BigInteger(int sign, byte[] bytes)
	{
	}

	public BigInteger(int sign, byte[] bytes, bool bigEndian)
	{
	}

	public BigInteger(int sign, byte[] bytes, int offset, int length)
	{
	}

	public BigInteger(int sign, byte[] bytes, int offset, int length, bool bigEndian)
	{
	}

	public BigInteger(int sizeInBits, Random random)
	{
	}

	public BigInteger(int bitLength, int certainty, Random random)
	{
	}

	public BigInteger Abs()
	{
		return null;
	}

	private static uint[] AddMagnitudes(uint[] a, uint[] b)
	{
		return null;
	}

	public BigInteger Add(BigInteger value)
	{
		return null;
	}

	private BigInteger AddToMagnitude(uint[] magToAdd)
	{
		return null;
	}

	public BigInteger And(BigInteger value)
	{
		return null;
	}

	public BigInteger AndNot(BigInteger val)
	{
		return null;
	}

	private static int CalcBitLength(int sign, int indx, uint[] mag)
	{
		return 0;
	}

	private static int BitLen(byte b)
	{
		return 0;
	}

	private static int BitLen(uint v)
	{
		return 0;
	}

	private bool QuickPow2Check()
	{
		return false;
	}

	public int CompareTo(object obj)
	{
		return 0;
	}

	public int CompareTo(BigInteger other)
	{
		return 0;
	}

	private static int CompareTo(int xIndx, uint[] x, int yIndx, uint[] y)
	{
		return 0;
	}

	private static int CompareNoLeadingZeros(int xIndx, uint[] x, int yIndx, uint[] y)
	{
		return 0;
	}

	private uint[] Divide(uint[] x, uint[] y)
	{
		return null;
	}

	public BigInteger Divide(BigInteger val)
	{
		return null;
	}

	public BigInteger[] DivideAndRemainder(BigInteger val)
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(BigInteger other)
	{
		return false;
	}

	private bool IsEqualMagnitude(BigInteger x)
	{
		return false;
	}

	public BigInteger Gcd(BigInteger value)
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	private BigInteger Inc()
	{
		return null;
	}

	public bool IsProbablePrime(int certainty)
	{
		return false;
	}

	internal bool IsProbablePrime(int certainty, bool randomlySelected)
	{
		return false;
	}

	private bool CheckProbablePrime(int certainty, Random random, bool randomlySelected)
	{
		return false;
	}

	public bool RabinMillerTest(int certainty, Random random)
	{
		return false;
	}

	internal bool RabinMillerTest(int certainty, Random random, bool randomlySelected)
	{
		return false;
	}

	public BigInteger Max(BigInteger value)
	{
		return null;
	}

	public BigInteger Min(BigInteger value)
	{
		return null;
	}

	public BigInteger Mod(BigInteger m)
	{
		return null;
	}

	public BigInteger ModDivide(BigInteger y, BigInteger m)
	{
		return null;
	}

	public BigInteger ModInverse(BigInteger m)
	{
		return null;
	}

	private BigInteger ModInversePow2(BigInteger m)
	{
		return null;
	}

	private static BigInteger ExtEuclid(BigInteger a, BigInteger b, out BigInteger u1Out)
	{
		u1Out = null;
		return null;
	}

	private static void ZeroOut(int[] x)
	{
	}

	public BigInteger ModMultiply(BigInteger y, BigInteger m)
	{
		return null;
	}

	public BigInteger ModSquare(BigInteger m)
	{
		return null;
	}

	public BigInteger ModPow(BigInteger e, BigInteger m)
	{
		return null;
	}

	private static BigInteger ModPowBarrett(BigInteger b, BigInteger e, BigInteger m)
	{
		return null;
	}

	private static BigInteger ReduceBarrett(BigInteger x, BigInteger m, BigInteger mr, BigInteger yu)
	{
		return null;
	}

	private static BigInteger ModPowMonty(uint[] yAccum, BigInteger b, BigInteger e, BigInteger m, bool convert)
	{
		return null;
	}

	private static BigInteger ModSquareMonty(uint[] yAccum, BigInteger b, BigInteger m)
	{
		return null;
	}

	private static uint[] GetWindowList(uint[] mag, int extraBits)
	{
		return null;
	}

	private static uint CreateWindowEntry(uint mult, uint zeros)
	{
		return 0u;
	}

	private static uint[] Square(uint[] w, uint[] x)
	{
		return null;
	}

	private static uint[] Multiply(uint[] x, uint[] y, uint[] z)
	{
		return null;
	}

	private uint GetMQuote()
	{
		return 0u;
	}

	private static void MontgomeryReduce(uint[] x, uint[] m, uint mDash)
	{
	}

	private static void MultiplyMonty(uint[] a, uint[] x, uint[] y, uint[] m, uint mDash, bool smallMontyModulus)
	{
	}

	private static void SquareMonty(uint[] a, uint[] x, uint[] m, uint mDash, bool smallMontyModulus)
	{
	}

	private static uint MultiplyMontyNIsOne(uint x, uint y, uint m, uint mDash)
	{
		return 0u;
	}

	public BigInteger Multiply(BigInteger val)
	{
		return null;
	}

	public BigInteger Square()
	{
		return null;
	}

	public BigInteger Negate()
	{
		return null;
	}

	public BigInteger NextProbablePrime()
	{
		return null;
	}

	public BigInteger Not()
	{
		return null;
	}

	public BigInteger Pow(int exp)
	{
		return null;
	}

	public static BigInteger ProbablePrime(int bitLength, Random random)
	{
		return null;
	}

	private int Remainder(int m)
	{
		return 0;
	}

	private static uint[] Remainder(uint[] x, uint[] y)
	{
		return null;
	}

	public BigInteger Remainder(BigInteger n)
	{
		return null;
	}

	private uint[] LastNBits(int n)
	{
		return null;
	}

	private BigInteger DivideWords(int w)
	{
		return null;
	}

	private BigInteger RemainderWords(int w)
	{
		return null;
	}

	private static uint[] ShiftLeft(uint[] mag, int n)
	{
		return null;
	}

	private static int ShiftLeftOneInPlace(int[] x, int carry)
	{
		return 0;
	}

	public BigInteger ShiftLeft(int n)
	{
		return null;
	}

	private static void ShiftRightInPlace(int start, uint[] mag, int n)
	{
	}

	private static void ShiftRightOneInPlace(int start, uint[] mag)
	{
	}

	public BigInteger ShiftRight(int n)
	{
		return null;
	}

	private static uint[] Subtract(int xStart, uint[] x, int yStart, uint[] y)
	{
		return null;
	}

	public BigInteger Subtract(BigInteger n)
	{
		return null;
	}

	private static uint[] DoSubBigLil(uint[] bigMag, uint[] lilMag)
	{
		return null;
	}

	public int GetLengthofByteArray()
	{
		return 0;
	}

	public int GetLengthofByteArrayUnsigned()
	{
		return 0;
	}

	public byte[] ToByteArray()
	{
		return null;
	}

	public byte[] ToByteArrayUnsigned()
	{
		return null;
	}

	private byte[] ToByteArray(bool unsigned)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(int radix)
	{
		return null;
	}

	private static void ToString(StringBuilder sb, int radix, IList<BigInteger> moduli, int scale, BigInteger pos)
	{
	}

	private static void AppendZeroExtendedString(StringBuilder sb, string s, int minLength)
	{
	}

	private static BigInteger CreateUValueOf(uint value)
	{
		return null;
	}

	private static BigInteger CreateUValueOf(ulong value)
	{
		return null;
	}

	public static BigInteger ValueOf(int value)
	{
		return null;
	}

	public static BigInteger ValueOf(long value)
	{
		return null;
	}

	public int GetLowestSetBit()
	{
		return 0;
	}

	private int GetLowestSetBitMaskFirst(uint firstWordMaskX)
	{
		return 0;
	}

	public bool TestBit(int n)
	{
		return false;
	}

	public BigInteger Or(BigInteger value)
	{
		return null;
	}

	public BigInteger Xor(BigInteger value)
	{
		return null;
	}

	public BigInteger SetBit(int n)
	{
		return null;
	}

	public BigInteger ClearBit(int n)
	{
		return null;
	}

	public BigInteger FlipBit(int n)
	{
		return null;
	}

	private BigInteger FlipExistingBit(int n)
	{
		return null;
	}
}
