using System;
using System.Net.Sockets;

namespace Mirror.SimpleWeb;

[Serializable]
public struct TcpConfig(bool noDelay, int sendTimeout, int receiveTimeout)
{
	public readonly bool noDelay = false;

	public readonly int sendTimeout = 0;

	public readonly int receiveTimeout = 0;

	public void ApplyTo(TcpClient client)
	{
	}
}
