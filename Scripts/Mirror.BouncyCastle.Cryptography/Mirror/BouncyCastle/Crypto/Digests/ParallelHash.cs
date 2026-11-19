namespace Mirror.BouncyCastle.Crypto.Digests;

public class ParallelHash : IXof, IDigest
{
	private static readonly byte[] N_PARALLEL_HASH;

	private readonly CShakeDigest cshake;

	private readonly CShakeDigest compressor;

	private readonly int bitLength;

	private readonly int outputLength;

	private readonly int B;

	private readonly byte[] buffer;

	private readonly byte[] compressorBuffer;

	private bool firstOutput;

	private int nCount;

	private int bufOff;

	public virtual string AlgorithmName => null;

	public ParallelHash(int bitLength, byte[] S, int B)
	{
	}

	public ParallelHash(int bitLength, byte[] S, int B, int outputSize)
	{
	}

	public ParallelHash(ParallelHash source)
	{
	}

	public virtual int GetByteLength()
	{
		return 0;
	}

	public virtual int GetDigestSize()
	{
		return 0;
	}

	public virtual void Update(byte b)
	{
	}

	public virtual void BlockUpdate(byte[] inBuf, int inOff, int len)
	{
	}

	private void Compress()
	{
	}

	private void Compress(byte[] buf, int offSet, int len)
	{
	}

	private void WrapUp(int outputSize)
	{
	}

	public virtual int DoFinal(byte[] outBuf, int outOff)
	{
		return 0;
	}

	public virtual int OutputFinal(byte[] outBuf, int outOff, int outLen)
	{
		return 0;
	}

	public virtual int Output(byte[] outBuf, int outOff, int outLen)
	{
		return 0;
	}

	public virtual void Reset()
	{
	}
}
