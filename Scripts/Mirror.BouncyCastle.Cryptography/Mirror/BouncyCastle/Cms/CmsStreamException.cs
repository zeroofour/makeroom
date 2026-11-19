using System;
using System.IO;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Cms;

[Serializable]
public class CmsStreamException : IOException
{
	public CmsStreamException()
	{
	}

	public CmsStreamException(string message)
	{
	}

	public CmsStreamException(string message, Exception innerException)
	{
	}

	protected CmsStreamException(SerializationInfo info, StreamingContext context)
	{
	}
}
