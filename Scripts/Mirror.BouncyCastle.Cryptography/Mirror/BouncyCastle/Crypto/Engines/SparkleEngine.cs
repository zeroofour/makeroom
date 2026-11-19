using System.Runtime.CompilerServices;
using Mirror.BouncyCastle.Crypto.Modes;

namespace Mirror.BouncyCastle.Crypto.Engines;

public sealed class SparkleEngine : IAeadCipher
{
	public enum SparkleParameters
	{
		SCHWAEMM128_128 = 0,
		SCHWAEMM256_128 = 1,
		SCHWAEMM192_192 = 2,
		SCHWAEMM256_256 = 3
	}

	private enum State
	{
		Uninitialized = 0,
		EncInit = 1,
		EncAad = 2,
		EncData = 3,
		EncFinal = 4,
		DecInit = 5,
		DecAad = 6,
		DecData = 7,
		DecFinal = 8
	}

	private static readonly uint[] RCON;

	private string algorithmName;

	private readonly uint[] state;

	private readonly uint[] k;

	private readonly uint[] npub;

	private byte[] tag;

	private bool encrypted;

	private State m_state;

	private byte[] initialAssociatedText;

	private readonly int m_bufferSizeDecrypt;

	private readonly byte[] m_buf;

	private int m_bufPos;

	private readonly int SCHWAEMM_KEY_LEN;

	private readonly int SCHWAEMM_NONCE_LEN;

	private readonly int SPARKLE_STEPS_SLIM;

	private readonly int SPARKLE_STEPS_BIG;

	private readonly int KEY_BYTES;

	private readonly int KEY_WORDS;

	private readonly int TAG_WORDS;

	private readonly int TAG_BYTES;

	private readonly int STATE_WORDS;

	private readonly int RATE_WORDS;

	private readonly int RATE_BYTES;

	private readonly int CAP_MASK;

	private readonly uint _A0;

	private readonly uint _A1;

	private readonly uint _M2;

	private readonly uint _M3;

	public string AlgorithmName => null;

	public SparkleEngine(SparkleParameters sparkleParameters)
	{
	}

	public int GetKeyBytesSize()
	{
		return 0;
	}

	public int GetIVBytesSize()
	{
		return 0;
	}

	public void Init(bool forEncryption, ICipherParameters parameters)
	{
	}

	public void ProcessAadByte(byte input)
	{
	}

	public void ProcessAadBytes(byte[] inBytes, int inOff, int len)
	{
	}

	public int ProcessByte(byte input, byte[] outBytes, int outOff)
	{
		return 0;
	}

	public int ProcessBytes(byte[] inBytes, int inOff, int len, byte[] outBytes, int outOff)
	{
		return 0;
	}

	public int DoFinal(byte[] outBytes, int outOff)
	{
		return 0;
	}

	public byte[] GetMac()
	{
		return null;
	}

	public int GetUpdateOutputSize(int len)
	{
		return 0;
	}

	public int GetOutputSize(int len)
	{
		return 0;
	}

	public void Reset()
	{
	}

	private void CheckAad()
	{
	}

	private bool CheckData()
	{
		return false;
	}

	private void FinishAad(State nextState)
	{
	}

	private void ProcessBufferAad(byte[] buffer, int bufOff)
	{
	}

	private void ProcessBufferDecrypt(byte[] buffer, int bufOff, byte[] output, int outOff)
	{
	}

	private void ProcessBufferEncrypt(byte[] buffer, int bufOff, byte[] output, int outOff)
	{
	}

	private void ProcessFinalAad()
	{
	}

	private void Reset(bool clearMac)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void ArxBox(uint rc, ref uint s00, ref uint s01)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static uint ELL(uint x)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void SparkleOpt(uint[] state, int steps)
	{
	}

	internal static void SparkleOpt8(uint[] state, int steps)
	{
	}

	internal static void SparkleOpt12(uint[] state, int steps)
	{
	}

	internal static void SparkleOpt16(uint[] state, int steps)
	{
	}
}
