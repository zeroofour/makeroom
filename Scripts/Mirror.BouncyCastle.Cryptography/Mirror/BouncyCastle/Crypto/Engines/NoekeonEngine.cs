namespace Mirror.BouncyCastle.Crypto.Engines;

public class NoekeonEngine : IBlockCipher
{
	private const int Size = 16;

	private static readonly byte[] RoundConstants;

	private readonly uint[] k;

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

	public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		return 0;
	}

	private int EncryptBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		return 0;
	}

	private int DecryptBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		return 0;
	}
}
