using Mirror.BouncyCastle.Crypto.Modes;

namespace Mirror.BouncyCastle.Crypto;

public class StreamBlockCipher : IStreamCipher
{
	private readonly IBlockCipherMode m_cipherMode;

	private readonly byte[] oneByte;

	public string AlgorithmName => null;

	public StreamBlockCipher(IBlockCipherMode cipherMode)
	{
	}

	public void Init(bool forEncryption, ICipherParameters parameters)
	{
	}

	public byte ReturnByte(byte input)
	{
		return 0;
	}

	public void ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
	{
	}

	public void Reset()
	{
	}
}
