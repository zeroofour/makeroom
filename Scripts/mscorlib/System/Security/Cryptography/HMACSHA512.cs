using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public class HMACSHA512 : HMAC
{
	private bool m_useLegacyBlockSize;

	private int BlockSize => 0;

	public HMACSHA512()
	{
	}

	public HMACSHA512(byte[] key)
	{
	}
}
