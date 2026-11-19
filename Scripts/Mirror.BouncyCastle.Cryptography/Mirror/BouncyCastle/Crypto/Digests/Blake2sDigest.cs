using System.Runtime.CompilerServices;

namespace Mirror.BouncyCastle.Crypto.Digests;

public sealed class Blake2sDigest : IDigest
{
	private static readonly uint[] blake2s_IV;

	private static readonly byte[,] blake2s_sigma;

	private const int ROUNDS = 10;

	private const int BLOCK_LENGTH_BYTES = 64;

	private int digestLength;

	private int keyLength;

	private byte[] salt;

	private byte[] personalization;

	private byte[] key;

	private int fanout;

	private int depth;

	private int leafLength;

	private long nodeOffset;

	private int nodeDepth;

	private int innerHashLength;

	private byte[] buffer;

	private int bufferPos;

	private uint[] internalState;

	private uint[] chainValue;

	private uint t0;

	private uint t1;

	private uint f0;

	public string AlgorithmName => null;

	public Blake2sDigest()
	{
	}

	public Blake2sDigest(Blake2sDigest digest)
	{
	}

	public Blake2sDigest(int digestBits)
	{
	}

	public Blake2sDigest(byte[] key)
	{
	}

	public Blake2sDigest(byte[] key, int digestBytes, byte[] salt, byte[] personalization)
	{
	}

	internal Blake2sDigest(int digestBytes, byte[] key, byte[] salt, byte[] personalization, long offset)
	{
	}

	internal Blake2sDigest(int digestBytes, int hashLength, long offset)
	{
	}

	private void Init(byte[] salt, byte[] personalization, byte[] key)
	{
	}

	private void InitializeInternalState()
	{
	}

	public void Update(byte b)
	{
	}

	public void BlockUpdate(byte[] message, int offset, int len)
	{
	}

	public int DoFinal(byte[] output, int outOffset)
	{
		return 0;
	}

	public void Reset()
	{
	}

	private void Compress(byte[] message, int messagePos)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void G(uint m1, uint m2, int posA, int posB, int posC, int posD)
	{
	}

	public int GetDigestSize()
	{
		return 0;
	}

	public int GetByteLength()
	{
		return 0;
	}

	public void ClearKey()
	{
	}

	public void ClearSalt()
	{
	}
}
