using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Security.Certificates;

[Serializable]
public class CertificateException : GeneralSecurityException
{
	public CertificateException()
	{
	}

	public CertificateException(string message)
	{
	}

	public CertificateException(string message, Exception innerException)
	{
	}

	protected CertificateException(SerializationInfo info, StreamingContext context)
	{
	}
}
