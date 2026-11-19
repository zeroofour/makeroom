namespace Mirror.BouncyCastle.Crypto.Digests;

public abstract class HarakaBase : IDigest
{
	internal static readonly int DIGEST_SIZE;

	internal static readonly byte[][] RC;

	private static readonly byte[,] S;

	public abstract string AlgorithmName { get; }

	private static byte SBox(byte x)
	{
		return 0;
	}

	private static byte[] SubBytes(byte[] s)
	{
		return null;
	}

	private static byte[] ShiftRows(byte[] s)
	{
		return null;
	}

	internal static byte[] AesEnc(byte[] s, byte[] rk)
	{
		return null;
	}

	private static byte MulX(byte p)
	{
		return 0;
	}

	private static byte[] MixColumns(byte[] s)
	{
		return null;
	}

	public int GetDigestSize()
	{
		return 0;
	}

	public abstract int GetByteLength();

	public abstract void Update(byte input);

	public abstract void BlockUpdate(byte[] input, int inOff, int length);

	public abstract int DoFinal(byte[] output, int outOff);

	public abstract void Reset();
}
