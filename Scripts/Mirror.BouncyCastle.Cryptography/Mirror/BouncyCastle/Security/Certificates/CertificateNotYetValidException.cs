using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Security.Certificates;

[Serializable]
public class CertificateNotYetValidException : CertificateException
{
	public CertificateNotYetValidException()
	{
	}

	public CertificateNotYetValidException(string message)
	{
	}

	public CertificateNotYetValidException(string message, Exception innerException)
	{
	}

	protected CertificateNotYetValidException(SerializationInfo info, StreamingContext context)
	{
	}
}
