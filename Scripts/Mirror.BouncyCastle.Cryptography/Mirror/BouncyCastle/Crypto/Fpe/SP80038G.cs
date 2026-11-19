using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Crypto.Fpe;

internal static class SP80038G
{
	internal static readonly string FPE_DISABLED;

	internal static readonly string FF1_DISABLED;

	private static readonly int BLOCK_SIZE;

	private static readonly double LOG2;

	private static readonly double TWO_TO_96;

	public static byte[] DecryptFF1(IBlockCipher cipher, int radix, byte[] tweak, byte[] buf, int off, int len)
	{
		return null;
	}

	public static ushort[] DecryptFF1w(IBlockCipher cipher, int radix, byte[] tweak, ushort[] buf, int off, int len)
	{
		return null;
	}

	private static ushort[] DecFF1(IBlockCipher cipher, int radix, byte[] T, int n, int u, int v, ushort[] A, ushort[] B)
	{
		return null;
	}

	public static byte[] DecryptFF3(IBlockCipher cipher, int radix, byte[] tweak64, byte[] buf, int off, int len)
	{
		return null;
	}

	public static byte[] DecryptFF3_1(IBlockCipher cipher, int radix, byte[] tweak56, byte[] buf, int off, int len)
	{
		return null;
	}

	public static ushort[] DecryptFF3_1w(IBlockCipher cipher, int radix, byte[] tweak56, ushort[] buf, int off, int len)
	{
		return null;
	}

	public static byte[] EncryptFF1(IBlockCipher cipher, int radix, byte[] tweak, byte[] buf, int off, int len)
	{
		return null;
	}

	public static ushort[] EncryptFF1w(IBlockCipher cipher, int radix, byte[] tweak, ushort[] buf, int off, int len)
	{
		return null;
	}

	private static ushort[] EncFF1(IBlockCipher cipher, int radix, byte[] T, int n, int u, int v, ushort[] A, ushort[] B)
	{
		return null;
	}

	public static byte[] EncryptFF3(IBlockCipher cipher, int radix, byte[] tweak64, byte[] buf, int off, int len)
	{
		return null;
	}

	public static ushort[] EncryptFF3w(IBlockCipher cipher, int radix, byte[] tweak64, ushort[] buf, int off, int len)
	{
		return null;
	}

	public static ushort[] EncryptFF3_1w(IBlockCipher cipher, int radix, byte[] tweak56, ushort[] buf, int off, int len)
	{
		return null;
	}

	public static byte[] EncryptFF3_1(IBlockCipher cipher, int radix, byte[] tweak56, byte[] buf, int off, int len)
	{
		return null;
	}

	private static int CalculateB_FF1(int radix, int v)
	{
		return 0;
	}

	private static BigInteger[] CalculateModUV(BigInteger bigRadix, int u, int v)
	{
		return null;
	}

	private static byte[] CalculateP_FF1(int radix, byte uLow, int n, int t)
	{
		return null;
	}

	private static byte[] CalculateTweak64_FF3_1(byte[] tweak56)
	{
		return null;
	}

	private static BigInteger CalculateY_FF1(IBlockCipher cipher, BigInteger bigRadix, byte[] T, int b, int d, int round, byte[] P, ushort[] AB)
	{
		return null;
	}

	private static BigInteger CalculateY_FF3(IBlockCipher cipher, BigInteger bigRadix, byte[] T, int wOff, uint round, ushort[] AB)
	{
		return null;
	}

	private static void CheckArgs(IBlockCipher cipher, bool isFF1, int radix, ushort[] buf, int off, int len)
	{
	}

	private static void CheckArgs(IBlockCipher cipher, bool isFF1, int radix, byte[] buf, int off, int len)
	{
	}

	private static void CheckCipher(IBlockCipher cipher)
	{
	}

	private static void CheckData(bool isFF1, int radix, ushort[] buf, int off, int len)
	{
	}

	private static void CheckData(bool isFF1, int radix, byte[] buf, int off, int len)
	{
	}

	private static void CheckLength(bool isFF1, int radix, int len)
	{
	}

	private static byte[] ImplDecryptFF3(IBlockCipher cipher, int radix, byte[] tweak64, byte[] buf, int off, int len)
	{
		return null;
	}

	private static ushort[] ImplDecryptFF3w(IBlockCipher cipher, int radix, byte[] tweak64, ushort[] buf, int off, int len)
	{
		return null;
	}

	private static ushort[] DecFF3_1(IBlockCipher cipher, int radix, byte[] T, int n, int v, int u, ushort[] A, ushort[] B)
	{
		return null;
	}

	private static byte[] ImplEncryptFF3(IBlockCipher cipher, int radix, byte[] tweak64, byte[] buf, int off, int len)
	{
		return null;
	}

	private static ushort[] ImplEncryptFF3w(IBlockCipher cipher, int radix, byte[] tweak64, ushort[] buf, int off, int len)
	{
		return null;
	}

	private static ushort[] EncFF3_1(IBlockCipher cipher, int radix, byte[] t, int n, int v, int u, ushort[] a, ushort[] b)
	{
		return null;
	}

	private static BigInteger Num(BigInteger R, ushort[] x)
	{
		return null;
	}

	private static byte[] Prf(IBlockCipher c, byte[] x)
	{
		return null;
	}

	private static void Str(BigInteger R, BigInteger x, int m, ushort[] output, int off)
	{
	}

	private static byte[] ToByte(ushort[] buf)
	{
		return null;
	}

	private static ushort[] ToShort(byte[] buf, int off, int len)
	{
		return null;
	}
}
