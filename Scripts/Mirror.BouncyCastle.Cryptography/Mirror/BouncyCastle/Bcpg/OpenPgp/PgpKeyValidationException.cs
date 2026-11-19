using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

[Serializable]
public class PgpKeyValidationException : PgpException
{
	public PgpKeyValidationException()
	{
	}

	public PgpKeyValidationException(string message)
	{
	}

	public PgpKeyValidationException(string message, Exception innerException)
	{
	}

	protected PgpKeyValidationException(SerializationInfo info, StreamingContext context)
	{
	}
}
