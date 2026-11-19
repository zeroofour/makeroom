namespace System.Net.Sockets;

public class TcpClient : IDisposable
{
	private Socket m_ClientSocket;

	private bool m_Active;

	private NetworkStream m_DataStream;

	private AddressFamily m_Family;

	private bool m_CleanedUp;

	public Socket Client
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool Connected => false;

	public int ReceiveTimeout
	{
		set
		{
		}
	}

	public int SendTimeout
	{
		set
		{
		}
	}

	public bool NoDelay
	{
		set
		{
		}
	}

	public TcpClient()
	{
	}

	public TcpClient(AddressFamily family)
	{
	}

	internal TcpClient(Socket acceptedSocket)
	{
	}

	public void Connect(string hostname, int port)
	{
	}

	public void Connect(IPEndPoint remoteEP)
	{
	}

	public NetworkStream GetStream()
	{
		return null;
	}

	public void Close()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public void Dispose()
	{
	}

	~TcpClient()
	{
	}

	private void initialize()
	{
	}
}
