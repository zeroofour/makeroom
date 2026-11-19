using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Security;

[Serializable]
public class KeyException : GeneralSecurityException
{
	public KeyException()
	{
	}

	public KeyException(string message)
	{
	}

	public KeyException(string message, Exception innerException)
	{
	}

	protected KeyException(SerializationInfo info, StreamingContext context)
	{
	}
}
