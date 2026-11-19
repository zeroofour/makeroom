using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Utilities;

[Serializable]
public class MemoableResetException : InvalidCastException
{
	public MemoableResetException()
	{
	}

	public MemoableResetException(string message)
	{
	}

	public MemoableResetException(string message, Exception innerException)
	{
	}

	protected MemoableResetException(SerializationInfo info, StreamingContext context)
	{
	}
}
