using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Security;

[Serializable]
public class InvalidParameterException : KeyException
{
	public InvalidParameterException()
	{
	}

	public InvalidParameterException(string message)
	{
	}

	public InvalidParameterException(string message, Exception innerException)
	{
	}

	protected InvalidParameterException(SerializationInfo info, StreamingContext context)
	{
	}
}
