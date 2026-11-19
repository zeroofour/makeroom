namespace Mirror.BouncyCastle.Crypto.Digests;

public sealed class Blake2xsDigest : IXof, IDigest
{
	public const int UnknownDigestLength = 65535;

	private const int DigestLength = 32;

	private const long MaxNumberBlocks = 4294967296L;

	private int digestLength;

	private Blake2sDigest hash;

	private byte[] h0;

	private byte[] buf;

	private int bufPos;

	private int digestPos;

	private long blockPos;

	private long nodeOffset;

	public string AlgorithmName => null;

	public Blake2xsDigest()
	{
	}

	public Blake2xsDigest(int digestBytes)
	{
	}

	public Blake2xsDigest(int digestBytes, byte[] key)
	{
	}

	public Blake2xsDigest(int digestBytes, byte[] key, byte[] salt, byte[] personalization)
	{
	}

	public Blake2xsDigest(Blake2xsDigest digest)
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

	public long GetUnknownMaxLength()
	{
		return 0L;
	}

	public void Update(byte b)
	{
	}

	public void BlockUpdate(byte[] input, int inOff, int inLen)
	{
	}

	public void Reset()
	{
	}

	public int DoFinal(byte[] output, int outOff)
	{
		return 0;
	}

	public int OutputFinal(byte[] output, int outOff, int outLen)
	{
		return 0;
	}

	public int Output(byte[] output, int outOff, int outLen)
	{
		return 0;
	}

	private int ComputeStepLength()
	{
		return 0;
	}

	private long ComputeNodeOffset()
	{
		return 0L;
	}
}
