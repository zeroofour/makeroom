using System.Runtime.CompilerServices;

namespace Mirror.BouncyCastle.Crypto.Digests;

public sealed class SparkleDigest : IDigest
{
	public enum SparkleParameters
	{
		ESCH256 = 0,
		ESCH384 = 1
	}

	private const int RATE_BYTES = 16;

	private const int RATE_WORDS = 4;

	private string algorithmName;

	private readonly uint[] state;

	private readonly byte[] m_buf;

	private readonly int DIGEST_BYTES;

	private readonly int SPARKLE_STEPS_SLIM;

	private readonly int SPARKLE_STEPS_BIG;

	private readonly int STATE_WORDS;

	private int m_bufPos;

	public string AlgorithmName => null;

	public SparkleDigest(SparkleParameters sparkleParameters)
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

	public void Update(byte input)
	{
	}

	public void BlockUpdate(byte[] input, int inOff, int inLen)
	{
	}

	public int DoFinal(byte[] output, int outOff)
	{
		return 0;
	}

	public void Reset()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void ProcessBlock(byte[] buf, int off, int steps)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static uint ELL(uint x)
	{
		return 0u;
	}
}
