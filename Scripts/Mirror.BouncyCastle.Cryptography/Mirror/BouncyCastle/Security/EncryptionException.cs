using System;
using System.IO;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Security;

[Serializable]
public class EncryptionException : IOException
{
	public EncryptionException()
	{
	}

	public EncryptionException(string message)
	{
	}

	public EncryptionException(string message, Exception innerException)
	{
	}

	protected EncryptionException(SerializationInfo info, StreamingContext context)
	{
	}
}
