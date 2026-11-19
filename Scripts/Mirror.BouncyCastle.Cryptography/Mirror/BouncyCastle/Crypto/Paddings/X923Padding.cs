using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Paddings;

public class X923Padding : IBlockCipherPadding
{
	private SecureRandom m_random;

	public string PaddingName => null;

	public void Init(SecureRandom random)
	{
	}

	public int AddPadding(byte[] input, int inOff)
	{
		return 0;
	}

	public int PadCount(byte[] input)
	{
		return 0;
	}
}
