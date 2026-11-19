using System;
using System.IO;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Pkcs;

[Serializable]
public class PkcsIOException : IOException
{
	public PkcsIOException()
	{
	}

	public PkcsIOException(string message)
	{
	}

	public PkcsIOException(string message, Exception innerException)
	{
	}

	protected PkcsIOException(SerializationInfo info, StreamingContext context)
	{
	}
}
