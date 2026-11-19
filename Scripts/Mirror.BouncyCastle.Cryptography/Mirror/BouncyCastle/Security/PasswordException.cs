using System;
using System.IO;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Security;

[Serializable]
public class PasswordException : IOException
{
	public PasswordException()
	{
	}

	public PasswordException(string message)
	{
	}

	public PasswordException(string message, Exception innerException)
	{
	}

	protected PasswordException(SerializationInfo info, StreamingContext context)
	{
	}
}
