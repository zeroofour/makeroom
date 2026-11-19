using System;
using Mirror.BouncyCastle.Crypto.Modes.Gcm;

namespace Mirror.BouncyCastle.Crypto.Modes;

public sealed class GcmBlockCipher : IAeadBlockCipher, IAeadCipher
{
	private const int BlockSize = 16;

	private readonly IBlockCipher cipher;

	private readonly IGcmMultiplier multiplier;

	private IGcmExponentiator exp;

	private bool forEncryption;

	private bool initialised;

	private int macSize;

	private byte[] lastKey;

	private byte[] nonce;

	private byte[] initialAssociatedText;

	private byte[] H;

	private byte[] J0;

	private byte[] bufBlock;

	private byte[] macBlock;

	private byte[] S;

	private byte[] S_at;

	private byte[] S_atPre;

	private byte[] counter;

	private uint counter32;

	private uint blocksRemaining;

	private int bufOff;

	private ulong totalLength;

	private byte[] atBlock;

	private int atBlockPos;

	private ulong atLength;

	private ulong atLengthPre;

	public string AlgorithmName => null;

	public IBlockCipher UnderlyingCipher => null;

	internal static IGcmMultiplier CreateGcmMultiplier()
	{
		return null;
	}

	public GcmBlockCipher(IBlockCipher c)
	{
	}

	[Obsolete("Will be removed")]
	public GcmBlockCipher(IBlockCipher c, IGcmMultiplier m)
	{
	}

	public int GetBlockSize()
	{
		return 0;
	}

	public void Init(bool forEncryption, ICipherParameters parameters)
	{
	}

	public byte[] GetMac()
	{
		return null;
	}

	public int GetOutputSize(int len)
	{
		return 0;
	}

	public int GetUpdateOutputSize(int len)
	{
		return 0;
	}

	public void ProcessAadByte(byte input)
	{
	}

	public void ProcessAadBytes(byte[] inBytes, int inOff, int len)
	{
	}

	private void InitCipher()
	{
	}

	public int ProcessByte(byte input, byte[] output, int outOff)
	{
		return 0;
	}

	public int ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
	{
		return 0;
	}

	public int DoFinal(byte[] output, int outOff)
	{
		return 0;
	}

	public void Reset()
	{
	}

	private void Reset(bool clearMac)
	{
	}

	private void DecryptBlock(byte[] inBuf, int inOff, byte[] outBuf, int outOff)
	{
	}

	private void DecryptBlocks2(byte[] inBuf, int inOff, byte[] outBuf, int outOff)
	{
	}

	private void EncryptBlock(byte[] inBuf, int inOff, byte[] outBuf, int outOff)
	{
	}

	private void EncryptBlocks2(byte[] inBuf, int inOff, byte[] outBuf, int outOff)
	{
	}

	private void GetNextCtrBlock(byte[] block)
	{
	}

	private void ProcessPartial(byte[] buf, int off, int len, byte[] output, int outOff)
	{
	}

	private void gHASH(byte[] Y, byte[] b, int len)
	{
	}

	private void gHASHBlock(byte[] Y, byte[] b)
	{
	}

	private void gHASHBlock(byte[] Y, byte[] b, int off)
	{
	}

	private void gHASHPartial(byte[] Y, byte[] b, int off, int len)
	{
	}

	private void CheckStatus()
	{
	}
}
