using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Crypto.Digests;

public sealed class Prehash : IDigest
{
	private readonly string m_algorithmName;

	private readonly LimitedBuffer m_buf;

	public string AlgorithmName => null;

	public static Prehash ForDigest(IDigest digest)
	{
		return null;
	}

	private Prehash(IDigest digest)
	{
	}

	public int GetByteLength()
	{
		return 0;
	}

	public int GetDigestSize()
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
}
