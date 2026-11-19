using System;
using Telepathy;
using UnityEngine;

namespace Mirror;

[DisallowMultipleComponent]
[HelpURL("https://github.com/vis2k/Telepathy/blob/master/README.md")]
public class TelepathyTransport : Transport, PortTransport
{
	public const string Scheme = "tcp4";

	public ushort port;

	[Header("Common")]
	[Tooltip("Nagle Algorithm can be disabled by enabling NoDelay")]
	public bool NoDelay;

	[Tooltip("Send timeout in milliseconds.")]
	public int SendTimeout;

	[Tooltip("Receive timeout in milliseconds. High by default so users don't time out during scene changes.")]
	public int ReceiveTimeout;

	[Tooltip("Protect against allocation attacks by keeping the max message size small. Otherwise an attacker might send multiple fake packets with 2GB headers, causing the server to run out of memory after allocating multiple large packets.")]
	[Header("Server")]
	public int serverMaxMessageSize;

	[Tooltip("Server processes a limit amount of messages per tick to avoid a deadlock where it might end up processing forever if messages come in faster than we can process them.")]
	public int serverMaxReceivesPerTick;

	[Tooltip("Server send queue limit per connection for pending messages. Telepathy will disconnect a connection's queues reach that limit for load balancing. Better to kick one slow client than slowing down the whole server.")]
	public int serverSendQueueLimitPerConnection;

	[Tooltip("Server receive queue limit per connection for pending messages. Telepathy will disconnect a connection's queues reach that limit for load balancing. Better to kick one slow client than slowing down the whole server.")]
	public int serverReceiveQueueLimitPerConnection;

	[Header("Client")]
	[Tooltip("Protect against allocation attacks by keeping the max message size small. Otherwise an attacker host might send multiple fake packets with 2GB headers, causing the connected clients to run out of memory after allocating multiple large packets.")]
	public int clientMaxMessageSize;

	[Tooltip("Client processes a limit amount of messages per tick to avoid a deadlock where it might end up processing forever if messages come in faster than we can process them.")]
	public int clientMaxReceivesPerTick;

	[Tooltip("Client send queue limit for pending messages. Telepathy will disconnect if the connection's queues reach that limit in order to avoid ever growing latencies.")]
	public int clientSendQueueLimit;

	[Tooltip("Client receive queue limit for pending messages. Telepathy will disconnect if the connection's queues reach that limit in order to avoid ever growing latencies.")]
	public int clientReceiveQueueLimit;

	private Client client;

	private Server server;

	private Func<bool> enabledCheck;

	public ushort Port
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public override bool Available()
	{
		return false;
	}

	private void CreateClient()
	{
	}

	public override bool ClientConnected()
	{
		return false;
	}

	public override void ClientConnect(string address)
	{
	}

	public override void ClientConnect(Uri uri)
	{
	}

	public override void ClientSend(ArraySegment<byte> segment, int channelId)
	{
	}

	public override void ClientDisconnect()
	{
	}

	public override void ClientEarlyUpdate()
	{
	}

	public override Uri ServerUri()
	{
		return null;
	}

	public override bool ServerActive()
	{
		return false;
	}

	public override void ServerStart()
	{
	}

	public override void ServerSend(int connectionId, ArraySegment<byte> segment, int channelId)
	{
	}

	public override void ServerDisconnect(int connectionId)
	{
	}

	public override string ServerGetClientAddress(int connectionId)
	{
		return null;
	}

	public override void ServerStop()
	{
	}

	public override void ServerEarlyUpdate()
	{
	}

	public override void Shutdown()
	{
	}

	public override int GetMaxPacketSize(int channelId)
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
