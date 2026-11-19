using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Crypto;

[Serializable]
public class CryptoException : Exception
{
	public CryptoException()
	{
	}

	public CryptoException(string message)
	{
	}

	public CryptoException(string message, Exception innerException)
	{
	}

	protected CryptoException(SerializationInfo info, StreamingContext context)
	{
	}
}
