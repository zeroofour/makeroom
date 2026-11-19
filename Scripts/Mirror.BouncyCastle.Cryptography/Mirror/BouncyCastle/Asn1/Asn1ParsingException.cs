using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Asn1;

[Serializable]
public class Asn1ParsingException : InvalidOperationException
{
	public Asn1ParsingException()
	{
	}

	public Asn1ParsingException(string message)
	{
	}

	public Asn1ParsingException(string message, Exception innerException)
	{
	}

	protected Asn1ParsingException(SerializationInfo info, StreamingContext context)
	{
	}
}
