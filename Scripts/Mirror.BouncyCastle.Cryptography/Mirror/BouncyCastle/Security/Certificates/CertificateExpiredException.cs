using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Security.Certificates;

[Serializable]
public class CertificateExpiredException : CertificateException
{
	public CertificateExpiredException()
	{
	}

	public CertificateExpiredException(string message)
	{
	}

	public CertificateExpiredException(string message, Exception innerException)
	{
	}

	protected CertificateExpiredException(SerializationInfo info, StreamingContext context)
	{
	}
}
