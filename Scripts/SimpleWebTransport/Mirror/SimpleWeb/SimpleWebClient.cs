using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Mirror.SimpleWeb;

public abstract class SimpleWebClient
{
	private readonly int maxMessagesPerTick;

	protected ClientState state;

	protected readonly int maxMessageSize;

	protected readonly BufferPool bufferPool;

	public readonly ConcurrentQueue<Message> receiveQueue;

	[CompilerGenerated]
	private Action m_onConnect;

	[CompilerGenerated]
	private Action m_onDisconnect;

	[CompilerGenerated]
	private Action<ArraySegment<byte>> m_onData;

	[CompilerGenerated]
	private Action<Exception> m_onError;

	public ClientState ConnectionState => ClientState.NotConnected;

	public event Action onConnect
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action onDisconnect
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<ArraySegment<byte>> onData
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<Exception> onError
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public abstract void Connect(Uri serverAddress);

	public abstract void Disconnect();

	public abstract void Send(ArraySegment<byte> segment);

	public static SimpleWebClient Create(int maxMessageSize, int maxMessagesPerTick, TcpConfig tcpConfig)
	{
		return null;
	}

	protected SimpleWebClient(int maxMessageSize, int maxMessagesPerTick)
	{
	}

	public void ProcessMessageQueue()
	{
	}

	public void ProcessMessageQueue(MonoBehaviour behaviour)
	{
	}
}
