using Mirror.BouncyCastle.Utilities;

namespace Mirror.BouncyCastle.Crypto.Digests;

public sealed class WhirlpoolDigest : IDigest, IMemoable
{
	private const int BITCOUNT_ARRAY_SIZE = 32;

	private const int BYTE_LENGTH = 64;

	private const int DIGEST_LENGTH_BYTES = 64;

	private const int REDUCTION_POLYNOMIAL = 285;

	private const int ROUNDS = 10;

	private static readonly int[] SBOX;

	private static readonly ulong[] C0;

	private static readonly ulong[] C1;

	private static readonly ulong[] C2;

	private static readonly ulong[] C3;

	private static readonly ulong[] C4;

	private static readonly ulong[] C5;

	private static readonly ulong[] C6;

	private static readonly ulong[] C7;

	private static readonly short[] EIGHT;

	private readonly ulong[] _rc;

	private byte[] _buffer;

	private int _bufferPos;

	private short[] _bitCount;

	private ulong[] _hash;

	private ulong[] _K;

	private ulong[] _L;

	private ulong[] _block;

	private ulong[] _state;

	public string AlgorithmName => null;

	static WhirlpoolDigest()
	{
	}

	private static int MulX(int input)
	{
		return 0;
	}

	private static ulong PackIntoUInt64(int b7, int b6, int b5, int b4, int b3, int b2, int b1, int b0)
	{
		return 0uL;
	}

	public WhirlpoolDigest()
	{
	}

	public WhirlpoolDigest(WhirlpoolDigest originalDigest)
	{
	}

	public int GetDigestSize()
	{
		return 0;
	}

	public int DoFinal(byte[] output, int outOff)
	{
		return 0;
	}

	public void Reset()
	{
	}

	private void ProcessFilledBuffer()
	{
	}

	private void ProcessBlock()
	{
	}

	public void Update(byte input)
	{
	}

	private void Increment()
	{
	}

	public void BlockUpdate(byte[] input, int inOff, int length)
	{
	}

	private void Finish()
	{
	}

	private byte[] CopyBitLength()
	{
		return null;
	}

	public int GetByteLength()
	{
		return 0;
	}

	public IMemoable Copy()
	{
		return null;
	}

	public void Reset(IMemoable other)
	{
	}
}
