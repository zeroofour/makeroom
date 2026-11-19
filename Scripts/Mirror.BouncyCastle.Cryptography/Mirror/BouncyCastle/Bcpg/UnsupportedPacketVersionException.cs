using System;
using System.Runtime.Serialization;

namespace Mirror.BouncyCastle.Bcpg;

[Serializable]
public class UnsupportedPacketVersionException : Exception
{
	public UnsupportedPacketVersionException()
	{
	}

	public UnsupportedPacketVersionException(string message)
	{
	}

	public UnsupportedPacketVersionException(string message, Exception innerException)
	{
	}

	protected UnsupportedPacketVersionException(SerializationInfo info, StreamingContext context)
	{
	}
}
