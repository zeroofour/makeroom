using Mirror.BouncyCastle.Crypto.Modes;
using Mirror.BouncyCastle.Crypto.Paddings;

namespace Mirror.BouncyCastle.Crypto.Macs;

public class CbcBlockCipherMac : IMac
{
	private byte[] buf;

	private int bufOff;

	private IBlockCipherMode m_cipherMode;

	private IBlockCipherPadding padding;

	private int macSize;

	public string AlgorithmName => null;

	public CbcBlockCipherMac(IBlockCipher cipher)
	{
	}

	public CbcBlockCipherMac(IBlockCipher cipher, IBlockCipherPadding padding)
	{
	}

	public CbcBlockCipherMac(IBlockCipher cipher, int macSizeInBits)
	{
	}

	public CbcBlockCipherMac(IBlockCipher cipher, int macSizeInBits, IBlockCipherPadding padding)
	{
	}

	public void Init(ICipherParameters parameters)
	{
	}

	public int GetMacSize()
	{
		return 0;
	}

	public void Update(byte input)
	{
	}

	public void BlockUpdate(byte[] input, int inOff, int len)
	{
	}

	public int DoFinal(byte[] output, int outOff)
	{
		return 0;
	}

	public void Reset()
	{
	}
}
