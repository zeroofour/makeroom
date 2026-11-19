using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Crypto;

[Serializable]
public class OutputLengthException : DataLengthException
{
	public OutputLengthException()
	{
	}

	public OutputLengthException(string message)
	{
	}

	public OutputLengthException(string message, Exception innerException)
	{
	}

	protected OutputLengthException(SerializationInfo info, StreamingContext context)
	{
	}
}
