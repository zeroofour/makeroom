namespace Mirror.BouncyCastle.Crypto.Engines;

public class HC256Engine : IStreamCipher
{
	private readonly uint[] p;

	private readonly uint[] q;

	private uint cnt;

	private byte[] key;

	private byte[] iv;

	private bool initialised;

	private readonly byte[] buf;

	private int idx;

	public virtual string AlgorithmName => null;

	private uint Step()
	{
		return 0u;
	}

	private void Init()
	{
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
	}

	private byte GetByte()
	{
		return 0;
	}

	public virtual void ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
	{
	}

	public virtual void Reset()
	{
	}

	public virtual byte ReturnByte(byte input)
	{
		return 0;
	}
}
