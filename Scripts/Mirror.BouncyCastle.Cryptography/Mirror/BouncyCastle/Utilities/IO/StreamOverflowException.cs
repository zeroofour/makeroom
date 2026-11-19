using System;
using System.IO;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Utilities.IO;

[Serializable]
public class StreamOverflowException : IOException
{
	public StreamOverflowException()
	{
	}

	public StreamOverflowException(string message)
	{
	}

	public StreamOverflowException(string message, Exception innerException)
	{
	}

	protected StreamOverflowException(SerializationInfo info, StreamingContext context)
	{
	}
}
