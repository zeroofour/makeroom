using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Crypto.Engines;

public sealed class AesLightEngine : IBlockCipher
{
	private static readonly byte[] S;

	private static readonly byte[] Si;

	private static readonly byte[] rcon;

	private const uint m1 = 2155905152u;

	private const uint m2 = 2139062143u;

	private const uint m3 = 27u;

	private const uint m4 = 3233857728u;

	private const uint m5 = 1061109567u;

	private int ROUNDS;

	private uint[][] WorkingKey;

	private bool forEncryption;

	private const int BLOCK_SIZE = 16;

	public string AlgorithmName => null;

	private static uint Shift(uint r, int shift)
	{
		return 0u;
	}

	private static uint FFmulX(uint x)
	{
		return 0u;
	}

	private static uint FFmulX2(uint x)
	{
		return 0u;
	}

	private static uint Mcol(uint x)
	{
		return 0u;
	}

	private static uint Inv_Mcol(uint x)
	{
		return 0u;
	}

	private static uint SubWord(uint x)
	{
		return 0u;
	}

	private uint[][] GenerateWorkingKey(KeyParameter keyParameter, bool forEncryption)
	{
		return null;
	}

	public void Init(bool forEncryption, ICipherParameters parameters)
	{
	}

	public int GetBlockSize()
	{
		return 0;
	}

	public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		return 0;
	}

	private void EncryptBlock(byte[] input, int inOff, byte[] output, int outOff, uint[][] KW)
	{
	}

	private void DecryptBlock(byte[] input, int inOff, byte[] output, int outOff, uint[][] KW)
	{
	}
}
