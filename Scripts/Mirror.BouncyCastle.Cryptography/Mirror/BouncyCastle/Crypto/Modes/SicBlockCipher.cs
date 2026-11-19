namespace Mirror.BouncyCastle.Crypto.Modes;

public class SicBlockCipher : IBlockCipherMode, IBlockCipher
{
	private readonly IBlockCipher cipher;

	private readonly int blockSize;

	private readonly byte[] counter;

	private readonly byte[] counterOut;

	private byte[] IV;

	public IBlockCipher UnderlyingCipher => null;

	public virtual string AlgorithmName => null;

	public virtual bool IsPartialBlockOkay => false;

	public SicBlockCipher(IBlockCipher cipher)
	{
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
	}

	public virtual int GetBlockSize()
	{
		return 0;
	}

	public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		return 0;
	}

	public virtual void Reset()
	{
	}
}
