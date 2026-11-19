namespace Mirror.BouncyCastle.Crypto.Modes;

public class EcbBlockCipher : IBlockCipherMode, IBlockCipher
{
	private readonly IBlockCipher m_cipher;

	public bool IsPartialBlockOkay => false;

	public string AlgorithmName => null;

	public IBlockCipher UnderlyingCipher => null;

	internal static IBlockCipherMode GetBlockCipherMode(IBlockCipher blockCipher)
	{
		return null;
	}

	public EcbBlockCipher(IBlockCipher cipher)
	{
	}

	public int GetBlockSize()
	{
		return 0;
	}

	public void Init(bool forEncryption, ICipherParameters parameters)
	{
	}

	public int ProcessBlock(byte[] inBuf, int inOff, byte[] outBuf, int outOff)
	{
		return 0;
	}

	public void Reset()
	{
	}
}
