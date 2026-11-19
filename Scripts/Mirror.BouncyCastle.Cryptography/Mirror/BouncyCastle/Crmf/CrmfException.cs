using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Crmf;

[Serializable]
public class CrmfException : Exception
{
	public CrmfException()
	{
	}

	public CrmfException(string message)
	{
	}

	public CrmfException(string message, Exception innerException)
	{
	}

	protected CrmfException(SerializationInfo info, StreamingContext context)
	{
	}
}
