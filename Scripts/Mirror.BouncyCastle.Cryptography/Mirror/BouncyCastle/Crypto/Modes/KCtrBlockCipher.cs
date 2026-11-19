namespace Mirror.BouncyCastle.Crypto.Modes;

public class KCtrBlockCipher : IStreamCipher, IBlockCipherMode, IBlockCipher
{
	private byte[] IV;

	private byte[] ofbV;

	private byte[] ofbOutV;

	private bool initialised;

	private int byteCount;

	private readonly int blockSize;

	private readonly IBlockCipher cipher;

	public IBlockCipher UnderlyingCipher => null;

	public string AlgorithmName => null;

	public bool IsPartialBlockOkay => false;

	public KCtrBlockCipher(IBlockCipher cipher)
	{
	}

	public void Init(bool forEncryption, ICipherParameters parameters)
	{
	}

	public int GetBlockSize()
	{
		return 0;
	}

	public byte ReturnByte(byte input)
	{
		return 0;
	}

	public void ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
	{
	}

	protected byte CalculateByte(byte b)
	{
		return 0;
	}

	public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		return 0;
	}

	public void Reset()
	{
	}

	private void incrementCounterAt(int pos)
	{
	}

	private void checkCounter()
	{
	}
}
