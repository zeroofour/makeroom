using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Ocsp;

[Serializable]
public class OcspException : Exception
{
	public OcspException()
	{
	}

	public OcspException(string message)
	{
	}

	public OcspException(string message, Exception innerException)
	{
	}

	protected OcspException(SerializationInfo info, StreamingContext context)
	{
	}
}
