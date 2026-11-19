using System.Runtime.CompilerServices;
using Mirror.BouncyCastle.Crypto.Modes;

namespace Mirror.BouncyCastle.Crypto.Engines;

public sealed class AsconEngine : IAeadCipher
{
	public enum AsconParameters
	{
		ascon80pq = 0,
		ascon128a = 1,
		ascon128 = 2
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

	private readonly AsconParameters asconParameters;

	private readonly int CRYPTO_KEYBYTES;

	private readonly int CRYPTO_ABYTES;

	private readonly int ASCON_AEAD_RATE;

	private readonly int nr;

	private byte[] mac;

	private ulong K0;

	private ulong K1;

	private ulong K2;

	private ulong N0;

	private ulong N1;

	private readonly ulong ASCON_IV;

	private ulong x0;

	private ulong x1;

	private ulong x2;

	private ulong x3;

	private ulong x4;

	private string algorithmName;

	private State m_state;

	private byte[] initialAssociatedText;

	private readonly int m_bufferSizeDecrypt;

	private readonly byte[] m_buf;

	private int m_bufPos;

	public string AlgorithmName => null;

	public AsconEngine(AsconParameters asconParameters)
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

	private void FinishData(State nextState)
	{
	}

	private void P(int nr)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void ROUND(ulong c)
	{
	}

	private void ascon_aeadinit()
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

	private void ProcessFinalDecrypt(byte[] input, int inOff, int inLen, byte[] output, int outOff)
	{
	}

	private void ProcessFinalEncrypt(byte[] input, int inOff, int inLen, byte[] output, int outOff)
	{
	}

	private void Reset(bool clearMac)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static ulong PAD(int i)
	{
		return 0uL;
	}
}
