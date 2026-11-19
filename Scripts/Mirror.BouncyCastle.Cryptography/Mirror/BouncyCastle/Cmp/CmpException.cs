using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Cmp;

[Serializable]
public class CmpException : Exception
{
	public CmpException()
	{
	}

	public CmpException(string message)
	{
	}

	public CmpException(string message, Exception innerException)
	{
	}

	protected CmpException(SerializationInfo info, StreamingContext context)
	{
	}
}
