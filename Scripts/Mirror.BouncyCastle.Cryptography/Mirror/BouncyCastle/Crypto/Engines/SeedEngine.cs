using System.Runtime.CompilerServices;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Crypto.Engines;

public class SeedEngine : IBlockCipher
{
	private const int BlockSize = 16;

	private static readonly uint[] SS0;

	private static readonly uint[] SS1;

	private static readonly uint[] SS2;

	private static readonly uint[] SS3;

	private static readonly uint[] KC;

	private int[] wKey;

	private bool forEncryption;

	public virtual string AlgorithmName => null;

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
	}

	public virtual int GetBlockSize()
	{
		return 0;
	}

	public virtual int ProcessBlock(byte[] inBuf, int inOff, byte[] outBuf, int outOff)
	{
		return 0;
	}

	private static int[] CreateWorkingKey(KeyParameter keyParameter)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static long F(int ki0, int ki1, long r)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int G(int x)
	{
		return 0;
	}
}
