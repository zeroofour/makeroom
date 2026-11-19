using System;
using System.Runtime.Serialization;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pkix;

[Serializable]
public class PkixCertPathBuilderException : GeneralSecurityException
{
	public PkixCertPathBuilderException()
	{
	}

	public PkixCertPathBuilderException(string message)
	{
	}

	public PkixCertPathBuilderException(string message, Exception innerException)
	{
	}

	protected PkixCertPathBuilderException(SerializationInfo info, StreamingContext context)
	{
	}
}
