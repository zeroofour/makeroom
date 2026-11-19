using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Cms;

[Serializable]
public class CmsAttributeTableGenerationException : CmsException
{
	public CmsAttributeTableGenerationException()
	{
	}

	public CmsAttributeTableGenerationException(string message)
	{
	}

	public CmsAttributeTableGenerationException(string message, Exception innerException)
	{
	}

	protected CmsAttributeTableGenerationException(SerializationInfo info, StreamingContext context)
	{
	}
}
