using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Security;

[Serializable]
public class SecurityUtilityException : Exception
{
	public SecurityUtilityException()
	{
	}

	public SecurityUtilityException(string message)
	{
	}

	public SecurityUtilityException(string message, Exception innerException)
	{
	}

	protected SecurityUtilityException(SerializationInfo info, StreamingContext context)
	{
	}
}
