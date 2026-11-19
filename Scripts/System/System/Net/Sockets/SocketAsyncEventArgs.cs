using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Net.Sockets;

public class SocketAsyncEventArgs : EventArgs, IDisposable
{
	private bool disposed;

	internal int in_progress;

	private EndPoint remote_ep;

	private Socket current_socket;

	internal SocketAsyncResult socket_async_result;

	private Exception ConnectByNameError;

	private bool DisconnectReuseSocket;

	private IPPacketInformation ReceiveMessageFromPacketInfo;

	private SendPacketsElement[] SendPacketsElements;

	private TransmitFileOptions SendPacketsFlags;

	private int SendPacketsSendSize;

	[CompilerGenerated]
	private EventHandler<SocketAsyncEventArgs> Completed;

	private Memory<byte> _buffer;

	private int _offset;

	private int _count;

	private bool _bufferIsExplicitArray;

	private IList<ArraySegment<byte>> _bufferList;

	private List<ArraySegment<byte>> _bufferListInternal;

	public Socket AcceptSocket { get; set; }

	public int BytesTransferred { get; private set; }

	private SocketAsyncOperation LastOperation { set; }

	public EndPoint RemoteEndPoint
	{
		set
		{
		}
	}

	public SocketError SocketError { get; set; }

	public SocketFlags SocketFlags { set; }

	public object UserToken { get; set; }

	internal Socket CurrentSocket => null;

	public Memory<byte> MemoryBuffer => default;

	public int Offset => 0;

	public int Count => 0;

	public IList<ArraySegment<byte>> BufferList => null;

	internal SocketAsyncEventArgs(bool flowExecutionContext)
	{
	}

	~SocketAsyncEventArgs()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	public void Dispose()
	{
	}

	internal void SetBytesTransferred(int value)
	{
	}

	internal void SetCurrentSocket(Socket socket)
	{
	}

	internal void SetLastOperation(SocketAsyncOperation op)
	{
	}

	internal void Complete_internal()
	{
	}

	protected virtual void OnCompleted(SocketAsyncEventArgs e)
	{
	}

	public void SetBuffer(Memory<byte> buffer)
	{
	}
}
