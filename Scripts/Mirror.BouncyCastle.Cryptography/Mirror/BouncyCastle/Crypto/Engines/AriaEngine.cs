namespace Mirror.BouncyCastle.Crypto.Engines;

public class AriaEngine : IBlockCipher
{
	private static readonly byte[][] C;

	private static readonly byte[] SB1_sbox;

	private static readonly byte[] SB2_sbox;

	private static readonly byte[] SB3_sbox;

	private static readonly byte[] SB4_sbox;

	protected const int BlockSize = 16;

	private byte[][] m_roundKeys;

	public virtual string AlgorithmName => null;

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

	protected static void A(byte[] z)
	{
	}

	protected static void FE(byte[] D, byte[] RK)
	{
	}

	protected static void FO(byte[] D, byte[] RK)
	{
	}

	protected static byte[][] KeySchedule(bool forEncryption, byte[] K)
	{
		return null;
	}

	protected static byte[] KeyScheduleRound(byte[] w, byte[] wr, int n)
	{
		return null;
	}

	protected static void ReverseKeys(byte[][] keys)
	{
	}

	protected static byte SB1(byte x)
	{
		return 0;
	}

	protected static byte SB2(byte x)
	{
		return 0;
	}

	protected static byte SB3(byte x)
	{
		return 0;
	}

	protected static byte SB4(byte x)
	{
		return 0;
	}

	protected static void SL1(byte[] z)
	{
	}

	protected static void SL2(byte[] z)
	{
	}

	protected static void Xor(byte[] z, byte[] x)
	{
	}
}
