using System.Runtime.Serialization;

namespace System;

[Serializable]
public class UnauthorizedAccessException : SystemException
{
	public UnauthorizedAccessException()
	{
	}

	public UnauthorizedAccessException(string message)
	{
	}

	protected UnauthorizedAccessException(SerializationInfo info, StreamingContext context)
	{
	}
}
