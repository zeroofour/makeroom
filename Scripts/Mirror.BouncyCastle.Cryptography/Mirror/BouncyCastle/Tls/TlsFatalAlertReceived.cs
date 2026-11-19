using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Tls;

[Serializable]
public class TlsFatalAlertReceived : TlsException
{
	protected readonly byte m_alertDescription;

	public virtual short AlertDescription => 0;

	public TlsFatalAlertReceived(short alertDescription)
	{
	}

	protected TlsFatalAlertReceived(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
