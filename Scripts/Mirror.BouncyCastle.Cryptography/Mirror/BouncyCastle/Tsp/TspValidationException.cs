using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Tsp;

[Serializable]
public class TspValidationException : TspException
{
	protected readonly int m_failureCode;

	public int FailureCode => 0;

	public TspValidationException(string message)
	{
	}

	public TspValidationException(string message, int failureCode)
	{
	}

	protected TspValidationException(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
