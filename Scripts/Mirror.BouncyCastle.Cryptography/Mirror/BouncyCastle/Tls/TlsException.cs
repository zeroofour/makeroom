using System;
using System.IO;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Tls;

[Serializable]
public class TlsException : IOException
{
	public TlsException()
	{
	}

	public TlsException(string message)
	{
	}

	public TlsException(string message, Exception innerException)
	{
	}

	protected TlsException(SerializationInfo info, StreamingContext context)
	{
	}
}
