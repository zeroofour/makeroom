using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Cms;

[Serializable]
public class CmsException : Exception
{
	public CmsException()
	{
	}

	public CmsException(string message)
	{
	}

	public CmsException(string message, Exception innerException)
	{
	}

	protected CmsException(SerializationInfo info, StreamingContext context)
	{
	}
}
