using System;
using System.Runtime.Serialization;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pkix;

[Serializable]
public class PkixCertPathValidatorException : GeneralSecurityException
{
	protected readonly int m_index;

	public int Index => 0;

	public PkixCertPathValidatorException()
	{
	}

	public PkixCertPathValidatorException(string message)
	{
	}

	public PkixCertPathValidatorException(string message, Exception innerException)
	{
	}

	public PkixCertPathValidatorException(string message, Exception innerException, int index)
	{
	}

	protected PkixCertPathValidatorException(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
