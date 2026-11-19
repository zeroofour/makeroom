using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Tsp;

[Serializable]
public class TspException : Exception
{
	public TspException()
	{
	}

	public TspException(string message)
	{
	}

	public TspException(string message, Exception innerException)
	{
	}

	protected TspException(SerializationInfo info, StreamingContext context)
	{
	}
}
