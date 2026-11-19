using System.IO;
using Mirror.BouncyCastle.Crypto.Modes;

namespace Mirror.BouncyCastle.Crypto.Engines;

public sealed class Grain128AeadEngine : IAeadCipher
{
	private static readonly int STATE_SIZE;

	private byte[] workingKey;

	private byte[] workingIV;

	private uint[] lfsr;

	private uint[] nfsr;

	private uint[] authAcc;

	private uint[] authSr;

	private bool initialised;

	private bool aadFinished;

	private MemoryStream aadData;

	private byte[] mac;

	public string AlgorithmName => null;

	public void Init(bool forEncryption, ICipherParameters param)
	{
	}

	private void InitGrain()
	{
	}

	private uint GetOutputNFSR()
	{
		return 0u;
	}

	private uint GetOutputLFSR()
	{
		return 0u;
	}

	private uint GetOutput()
	{
		return 0u;
	}

	private uint[] Shift(uint[] array, uint val)
	{
		return null;
	}

	private void SetKey(byte[] keyBytes, byte[] ivBytes)
	{
	}

	public int ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
	{
		return 0;
	}

	public void Reset()
	{
	}

	private void Reset(bool clearMac)
	{
	}

	private void GetKeyStream(byte[] input, int inOff, int len, byte[] ciphertext, int outOff)
	{
	}

	public byte ReturnByte(byte input)
	{
		return 0;
	}

	public void ProcessAadByte(byte input)
	{
	}

	public void ProcessAadBytes(byte[] input, int inOff, int len)
	{
	}

	private void Accumulate()
	{
	}

	private void AuthShift(uint val)
	{
	}

	public int ProcessByte(byte input, byte[] output, int outOff)
	{
		return 0;
	}

	private void DoProcessAADBytes(byte[] input, int inOff, int len)
	{
	}

	public int DoFinal(byte[] output, int outOff)
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

	private static int LenLength(int v)
	{
		return 0;
	}
}
