using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Crypto;

[Serializable]
public class InvalidCipherTextException : CryptoException
{
	public InvalidCipherTextException()
	{
	}

	public InvalidCipherTextException(string message)
	{
	}

	public InvalidCipherTextException(string message, Exception innerException)
	{
	}

	protected InvalidCipherTextException(SerializationInfo info, StreamingContext context)
	{
	}
}
