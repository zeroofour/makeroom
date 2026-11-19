using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Pkix;

[Serializable]
public class PkixNameConstraintValidatorException : Exception
{
	public PkixNameConstraintValidatorException()
	{
	}

	public PkixNameConstraintValidatorException(string message)
	{
	}

	public PkixNameConstraintValidatorException(string message, Exception innerException)
	{
	}

	protected PkixNameConstraintValidatorException(SerializationInfo info, StreamingContext context)
	{
	}
}
