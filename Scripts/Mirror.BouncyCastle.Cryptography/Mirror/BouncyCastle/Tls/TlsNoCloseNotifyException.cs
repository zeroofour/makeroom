using System;
using System.IO;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Tls;

[Serializable]
public class TlsNoCloseNotifyException : EndOfStreamException
{
	public TlsNoCloseNotifyException()
	{
	}

	protected TlsNoCloseNotifyException(SerializationInfo info, StreamingContext context)
	{
	}
}
