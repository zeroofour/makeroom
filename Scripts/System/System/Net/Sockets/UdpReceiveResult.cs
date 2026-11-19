namespace System.Net.Sockets;

public struct UdpReceiveResult(byte[] buffer, IPEndPoint remoteEndPoint) : IEquatable<UdpReceiveResult>
{
	private byte[] m_buffer = null;

	private IPEndPoint m_remoteEndPoint = null;

	public byte[] Buffer => null;

	public IPEndPoint RemoteEndPoint => null;

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(UdpReceiveResult other)
	{
		return false;
	}
}
