using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Security.Certificates;

[Serializable]
public class CrlException : GeneralSecurityException
{
	public CrlException()
	{
	}

	public CrlException(string message)
	{
	}

	public CrlException(string message, Exception innerException)
	{
	}

	protected CrlException(SerializationInfo info, StreamingContext context)
	{
	}
}
