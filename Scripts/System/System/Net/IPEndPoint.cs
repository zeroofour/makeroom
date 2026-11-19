using System.Net.Sockets;

namespace System.Net;

[Serializable]
public class IPEndPoint : EndPoint
{
	public const int MinPort = 0;

	public const int MaxPort = 65535;

	private IPAddress _address;

	private int _port;

	internal const int AnyPort = 0;

	internal static IPEndPoint Any;

	internal static IPEndPoint IPv6Any;

	public override AddressFamily AddressFamily => AddressFamily.Unspecified;

	public IPAddress Address => null;

	public int Port => 0;

	public IPEndPoint(IPAddress address, int port)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public override SocketAddress Serialize()
	{
		return null;
	}

	public override EndPoint Create(SocketAddress socketAddress)
	{
		return null;
	}

	public override bool Equals(object comparand)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
