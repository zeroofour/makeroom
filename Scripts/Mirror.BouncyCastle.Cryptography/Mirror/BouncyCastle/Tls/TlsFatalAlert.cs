using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Tls;

[Serializable]
public class TlsFatalAlert : TlsException
{
	protected readonly byte m_alertDescription;

	public virtual short AlertDescription => 0;

	private static string GetMessage(short alertDescription, string detailMessage)
	{
		return null;
	}

	public TlsFatalAlert(short alertDescription)
	{
	}

	public TlsFatalAlert(short alertDescription, string detailMessage)
	{
	}

	public TlsFatalAlert(short alertDescription, Exception alertCause)
	{
	}

	public TlsFatalAlert(short alertDescription, string detailMessage, Exception alertCause)
	{
	}

	protected TlsFatalAlert(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
