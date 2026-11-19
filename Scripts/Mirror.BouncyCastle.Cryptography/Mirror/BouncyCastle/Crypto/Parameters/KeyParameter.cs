namespace Mirror.BouncyCastle.Crypto.Parameters;

public class KeyParameter : ICipherParameters
{
	private readonly byte[] m_key;

	public int KeyLength => 0;

	public KeyParameter(byte[] key)
	{
	}

	public KeyParameter(byte[] key, int keyOff, int keyLen)
	{
	}

	private KeyParameter(int length)
	{
	}

	public void CopyTo(byte[] buf, int off, int len)
	{
	}

	public byte[] GetKey()
	{
		return null;
	}

	internal bool FixedTimeEquals(byte[] data)
	{
		return false;
	}

	public KeyParameter Reverse()
	{
		return null;
	}
}
