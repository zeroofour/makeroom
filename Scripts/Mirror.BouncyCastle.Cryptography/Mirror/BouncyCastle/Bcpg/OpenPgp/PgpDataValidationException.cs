using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

[Serializable]
public class PgpDataValidationException : PgpException
{
	public PgpDataValidationException()
	{
	}

	public PgpDataValidationException(string message)
	{
	}

	public PgpDataValidationException(string message, Exception innerException)
	{
	}

	protected PgpDataValidationException(SerializationInfo info, StreamingContext context)
	{
	}
}
