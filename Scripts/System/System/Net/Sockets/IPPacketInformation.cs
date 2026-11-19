namespace System.Net.Sockets;

public struct IPPacketInformation
{
	private IPAddress address;

	private int networkInterface;

	public override bool Equals(object comparand)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
