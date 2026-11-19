namespace Mirror.BouncyCastle.Crypto.Modes;

public sealed class CbcBlockCipher : IBlockCipherMode, IBlockCipher
{
	private byte[] IV;

	private byte[] cbcV;

	private byte[] cbcNextV;

	private int blockSize;

	private IBlockCipher cipher;

	private bool encrypting;

	public IBlockCipher UnderlyingCipher => null;

	public string AlgorithmName => null;

	public bool IsPartialBlockOkay => false;

	public CbcBlockCipher(IBlockCipher cipher)
	{
	}

	public void Init(bool forEncryption, ICipherParameters parameters)
	{
	}

	public int GetBlockSize()
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

	private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
	{
		return 0;
	}

	private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
	{
		return 0;
	}
}
