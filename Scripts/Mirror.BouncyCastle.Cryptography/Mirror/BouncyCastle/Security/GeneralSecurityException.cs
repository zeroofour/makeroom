using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Security;

[Serializable]
public class GeneralSecurityException : Exception
{
	public GeneralSecurityException()
	{
	}

	public GeneralSecurityException(string message)
	{
	}

	public GeneralSecurityException(string message, Exception innerException)
	{
	}

	protected GeneralSecurityException(SerializationInfo info, StreamingContext context)
	{
	}
}
