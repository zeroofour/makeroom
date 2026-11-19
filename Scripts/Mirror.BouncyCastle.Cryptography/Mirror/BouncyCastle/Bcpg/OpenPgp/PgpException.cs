using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

[Serializable]
public class PgpException : Exception
{
	public PgpException()
	{
	}

	public PgpException(string message)
	{
	}

	public PgpException(string message, Exception innerException)
	{
	}

	protected PgpException(SerializationInfo info, StreamingContext context)
	{
	}
}
