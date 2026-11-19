using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Pkcs;

[Serializable]
public class PkcsException : Exception
{
	public PkcsException()
	{
	}

	public PkcsException(string message)
	{
	}

	public PkcsException(string message, Exception innerException)
	{
	}

	protected PkcsException(SerializationInfo info, StreamingContext context)
	{
	}
}
