namespace Mirror.BouncyCastle.Crypto.Digests;

public class TupleHash : IXof, IDigest
{
	private static readonly byte[] N_TUPLE_HASH;

	private readonly CShakeDigest cshake;

	private readonly int bitLength;

	private readonly int outputLength;

	private bool firstOutput;

	public virtual string AlgorithmName => null;

	public TupleHash(int bitLength, byte[] S)
	{
	}

	public TupleHash(int bitLength, byte[] S, int outputSize)
	{
	}

	public TupleHash(TupleHash original)
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
