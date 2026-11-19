using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Security.Certificates;

[Serializable]
public class CertificateEncodingException : CertificateException
{
	public CertificateEncodingException()
	{
	}

	public CertificateEncodingException(string message)
	{
	}

	public CertificateEncodingException(string message, Exception innerException)
	{
	}

	protected CertificateEncodingException(SerializationInfo info, StreamingContext context)
	{
	}
}
