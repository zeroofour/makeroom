namespace System.Net.Sockets;

public class TcpListener
{
	private IPEndPoint m_ServerSocketEP;

	private Socket m_ServerSocket;

	private bool m_Active;

	private bool m_ExclusiveAddressUse;

	public Socket Server => null;

	public TcpListener(IPAddress localaddr, int port)
	{
	}

	public static TcpListener Create(int port)
	{
		return null;
	}

	public void Start()
	{
	}

	public void Start(int backlog)
	{
	}

	public void Stop()
	{
	}

	public TcpClient AcceptTcpClient()
	{
		return null;
	}
}
