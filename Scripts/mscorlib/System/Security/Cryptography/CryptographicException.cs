using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Security.Cryptography;

[Serializable]
[ComVisible(true)]
public class CryptographicException : SystemException
{
	public CryptographicException()
	{
	}

	public CryptographicException(string message)
	{
	}

	public CryptographicException(string format, string insert)
	{
	}

	public CryptographicException(string message, Exception inner)
	{
	}

	public CryptographicException(int hr)
	{
	}

	protected CryptographicException(SerializationInfo info, StreamingContext context)
	{
	}
}
