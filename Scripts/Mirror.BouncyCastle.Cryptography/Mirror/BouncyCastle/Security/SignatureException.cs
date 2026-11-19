using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Security;

[Serializable]
public class SignatureException : GeneralSecurityException
{
	public SignatureException()
	{
	}

	public SignatureException(string message)
	{
	}

	public SignatureException(string message, Exception innerException)
	{
	}

	protected SignatureException(SerializationInfo info, StreamingContext context)
	{
	}
}
