using System;
using System.IO;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Asn1;

[Serializable]
public class Asn1Exception : IOException
{
	public Asn1Exception()
	{
	}

	public Asn1Exception(string message)
	{
	}

	public Asn1Exception(string message, Exception innerException)
	{
	}

	protected Asn1Exception(SerializationInfo info, StreamingContext context)
	{
	}
}
