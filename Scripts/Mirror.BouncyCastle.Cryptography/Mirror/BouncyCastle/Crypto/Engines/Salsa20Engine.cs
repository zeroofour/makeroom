using System.Runtime.CompilerServices;

namespace Mirror.BouncyCastle.Crypto.Engines;

public class Salsa20Engine : IStreamCipher
{
	public static readonly int DEFAULT_ROUNDS;

	private const int StateSize = 16;

	private static readonly uint[] TAU_SIGMA;

	protected int rounds;

	internal int index;

	internal uint[] engineState;

	internal uint[] x;

	internal byte[] keyStream;

	internal bool initialised;

	private uint cW0;

	private uint cW1;

	private uint cW2;

	protected virtual int NonceSize => 0;

	public virtual string AlgorithmName => null;

	internal static void PackTauOrSigma(int keyLength, uint[] state, int stateOffset)
	{
	}

	public Salsa20Engine()
	{
	}

	public Salsa20Engine(int rounds)
	{
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
	}

	public virtual byte ReturnByte(byte input)
	{
		return 0;
	}

	protected virtual void AdvanceCounter()
	{
	}

	public virtual void ProcessBytes(byte[] inBytes, int inOff, int len, byte[] outBytes, int outOff)
	{
	}

	public virtual void Reset()
	{
	}

	protected virtual void ResetCounter()
	{
	}

	protected virtual void SetKey(byte[] keyBytes, byte[] ivBytes)
	{
	}

	protected virtual void GenerateKeyStream(byte[] output)
	{
	}

	internal static void SalsaCore(int rounds, uint[] input, uint[] output)
	{
	}

	internal void ResetLimitCounter()
	{
	}

	internal bool LimitExceeded()
	{
		return false;
	}

	internal bool LimitExceeded(uint len)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void QuarterRound(ref uint a, ref uint b, ref uint c, ref uint d)
	{
	}
}
