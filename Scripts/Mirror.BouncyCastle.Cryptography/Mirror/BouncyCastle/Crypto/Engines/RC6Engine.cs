namespace Mirror.BouncyCastle.Crypto.Engines;

public class RC6Engine : IBlockCipher
{
	private static readonly int _noRounds;

	private int[] _S;

	private static readonly int P32;

	private static readonly int Q32;

	private static readonly int LGW;

	private bool forEncryption;

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

	private void SetKey(byte[] key)
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
