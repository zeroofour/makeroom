namespace Mirror.BouncyCastle.Crypto.Engines;

public class XteaEngine : IBlockCipher
{
	private const int rounds = 32;

	private const int block_size = 8;

	private const int delta = -1640531527;

	private uint[] _S;

	private uint[] _sum0;

	private uint[] _sum1;

	private bool _initialised;

	private bool _forEncryption;

	public virtual string AlgorithmName => null;

	public virtual int GetBlockSize()
	{
		return 0;
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
	}

	public virtual int ProcessBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
	{
		return 0;
	}

	private void setKey(byte[] key)
	{
	}

	private int EncryptBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
	{
		return 0;
	}

	private int DecryptBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
	{
		return 0;
	}
}
