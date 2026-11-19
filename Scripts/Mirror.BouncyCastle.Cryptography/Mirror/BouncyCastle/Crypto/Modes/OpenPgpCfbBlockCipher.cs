namespace Mirror.BouncyCastle.Crypto.Modes;

public class OpenPgpCfbBlockCipher : IBlockCipherMode, IBlockCipher
{
	private byte[] IV;

	private byte[] FR;

	private byte[] FRE;

	private readonly IBlockCipher cipher;

	private readonly int blockSize;

	private int count;

	private bool forEncryption;

	public IBlockCipher UnderlyingCipher => null;

	public string AlgorithmName => null;

	public bool IsPartialBlockOkay => false;

	public OpenPgpCfbBlockCipher(IBlockCipher cipher)
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

	public void Init(bool forEncryption, ICipherParameters parameters)
	{
	}

	private byte EncryptByte(byte data, int blockOff)
	{
		return 0;
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
