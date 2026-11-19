using System.Threading.Tasks;

namespace System.Net.Sockets;

public class UdpClient : IDisposable
{
	private const int MaxUDPSize = 65536;

	private Socket m_ClientSocket;

	private bool m_Active;

	private byte[] m_Buffer;

	private AddressFamily m_Family;

	private bool m_CleanedUp;

	private bool m_IsBroadcast;

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

	public bool MulticastLoopback
	{
		set
		{
		}
	}

	public bool EnableBroadcast
	{
		set
		{
		}
	}

	public UdpClient()
	{
	}

	public UdpClient(AddressFamily family)
	{
	}

	public UdpClient(int port)
	{
	}

	public UdpClient(int port, AddressFamily family)
	{
	}

	public void Close()
	{
	}

	private void FreeResources()
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public void Connect(IPEndPoint endPoint)
	{
	}

	private void CheckForBroadcast(IPAddress ipAddress)
	{
	}

	private static bool IsBroadcast(IPAddress address)
	{
		return false;
	}

	public int Send(byte[] dgram, int bytes, IPEndPoint endPoint)
	{
		return 0;
	}

	public IAsyncResult BeginSend(byte[] datagram, int bytes, IPEndPoint endPoint, AsyncCallback requestCallback, object state)
	{
		return null;
	}

	public IAsyncResult BeginSend(byte[] datagram, int bytes, AsyncCallback requestCallback, object state)
	{
		return null;
	}

	public int EndSend(IAsyncResult asyncResult)
	{
		return 0;
	}

	public IAsyncResult BeginReceive(AsyncCallback requestCallback, object state)
	{
		return null;
	}

	public byte[] EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP)
	{
		return null;
	}

	public Task<int> SendAsync(byte[] datagram, int bytes)
	{
		return null;
	}

	public Task<int> SendAsync(byte[] datagram, int bytes, IPEndPoint endPoint)
	{
		return null;
	}

	public Task<UdpReceiveResult> ReceiveAsync()
	{
		return null;
	}

	private void createClientSocket()
	{
	}
}
