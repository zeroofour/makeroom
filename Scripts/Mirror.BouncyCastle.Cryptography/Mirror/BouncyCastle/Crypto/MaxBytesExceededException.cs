using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Crypto;

[Serializable]
public class MaxBytesExceededException : CryptoException
{
	public MaxBytesExceededException()
	{
	}

	public MaxBytesExceededException(string message)
	{
	}

	public MaxBytesExceededException(string message, Exception innerException)
	{
	}

	protected MaxBytesExceededException(SerializationInfo info, StreamingContext context)
	{
	}
}
