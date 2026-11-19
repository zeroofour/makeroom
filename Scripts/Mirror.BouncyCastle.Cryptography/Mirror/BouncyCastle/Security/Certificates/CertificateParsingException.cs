using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Security.Certificates;

[Serializable]
public class CertificateParsingException : CertificateException
{
	public CertificateParsingException()
	{
	}

	public CertificateParsingException(string message)
	{
	}

	public CertificateParsingException(string message, Exception innerException)
	{
	}

	protected CertificateParsingException(SerializationInfo info, StreamingContext context)
	{
	}
}
