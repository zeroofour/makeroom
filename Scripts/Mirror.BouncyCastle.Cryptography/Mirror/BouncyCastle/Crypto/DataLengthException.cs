using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Crypto;

[Serializable]
public class DataLengthException : CryptoException
{
	public DataLengthException()
	{
	}

	public DataLengthException(string message)
	{
	}

	public DataLengthException(string message, Exception innerException)
	{
	}

	protected DataLengthException(SerializationInfo info, StreamingContext context)
	{
	}
}
