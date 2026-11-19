namespace Mirror.BouncyCastle.Crypto.Parameters;

public sealed class Blake3Parameters : ICipherParameters
{
	private const int KeyLen = 32;

	private byte[] m_theKey;

	private byte[] m_theContext;

	public static Blake3Parameters Context(byte[] pContext)
	{
		return null;
	}

	public static Blake3Parameters Key(byte[] pKey)
	{
		return null;
	}

	public byte[] GetKey()
	{
		return null;
	}

	public void ClearKey()
	{
	}

	public byte[] GetContext()
	{
		return null;
	}
}
