using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Security;

[Serializable]
public class InvalidKeyException : KeyException
{
	public InvalidKeyException()
	{
	}

	public InvalidKeyException(string message)
	{
	}

	public InvalidKeyException(string message, Exception innerException)
	{
	}

	protected InvalidKeyException(SerializationInfo info, StreamingContext context)
	{
	}
}
