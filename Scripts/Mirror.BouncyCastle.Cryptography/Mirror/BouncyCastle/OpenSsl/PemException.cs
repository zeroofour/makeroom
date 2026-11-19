using System;
using System.IO;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.OpenSsl;

[Serializable]
public class PemException : IOException
{
	public PemException()
	{
	}

	public PemException(string message)
	{
	}

	public PemException(string message, Exception innerException)
	{
	}

	protected PemException(SerializationInfo info, StreamingContext context)
	{
	}
}
