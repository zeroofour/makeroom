using System;
using Mirror;
using UnityEngine;
using UnityEngine.Serialization;

namespace kcp2k;

[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/transports/kcp-transport")]
public class KcpTransport : Transport, PortTransport
{
	public const string Scheme = "kcp";

	[Header("Transport Configuration")]
	[FormerlySerializedAs("Port")]
	public ushort port;

	[Tooltip("DualMode listens to IPv6 and IPv4 simultaneously. Disable if the platform only supports IPv4.")]
	public bool DualMode;

	[Tooltip("NoDelay is recommended to reduce latency. This also scales better without buffers getting full.")]
	public bool NoDelay;

	[Tooltip("KCP internal update interval. 100ms is KCP default, but a lower interval is recommended to minimize latency and to scale to more networked entities.")]
	public uint Interval;

	[Tooltip("KCP timeout in milliseconds. Note that KCP sends a ping automatically.")]
	public int Timeout;

	[Tooltip("Socket receive buffer size. Large buffer helps support more connections. Increase operating system socket buffer size limits if needed.")]
	public int RecvBufferSize;

	[Tooltip("Socket send buffer size. Large buffer helps support more connections. Increase operating system socket buffer size limits if needed.")]
	public int SendBufferSize;

	[Header("Advanced")]
	[Tooltip("KCP fastresend parameter. Faster resend for the cost of higher bandwidth. 0 in normal mode, 2 in turbo mode.")]
	public int FastResend;

	[Tooltip("KCP congestion window. Restricts window size to reduce congestion. Results in only 2-3 MTU messages per Flush even on loopback. Best to keept his disabled.")]
	private bool CongestionWindow;

	[Tooltip("KCP window size can be modified to support higher loads. This also increases max message size.")]
	public uint ReceiveWindowSize;

	[Tooltip("KCP window size can be modified to support higher loads.")]
	public uint SendWindowSize;

	[Tooltip("KCP will try to retransmit lost messages up to MaxRetransmit (aka dead_link) before disconnecting.")]
	public uint MaxRetransmit;

	[FormerlySerializedAs("MaximizeSendReceiveBuffersToOSLimit")]
	[Tooltip("Enable to automatically set client & server send/recv buffers to OS limit. Avoids issues with too small buffers under heavy load, potentially dropping connections. Increase the OS limit if this is still too small.")]
	public bool MaximizeSocketBuffers;

	[ReadOnly]
	[Tooltip("KCP reliable max message size shown for convenience. Can be changed via ReceiveWindowSize.")]
	[Header("Allowed Max Message Sizes\nBased on Receive Window Size")]
	public int ReliableMaxMessageSize;

	[Tooltip("KCP unreliable channel max message size for convenience. Not changeable.")]
	[ReadOnly]
	public int UnreliableMaxMessageSize;

	protected KcpConfig config;

	private const int MTU = 1200;

	protected KcpServer server;

	protected KcpClient client;

	[Header("Debug")]
	public bool debugLog;

	public bool statisticsGUI;

	public bool statisticsLog;

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

	public static int FromKcpChannel(KcpChannel channel)
	{
		return 0;
	}

	public static KcpChannel ToKcpChannel(int channel)
	{
		return (KcpChannel)0;
	}

	public static TransportError ToTransportError(ErrorCode error)
	{
		return TransportError.DnsResolve;
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnValidate()
	{
	}

	public override bool Available()
	{
		return false;
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

	public override void ClientLateUpdate()
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

	public override void ServerLateUpdate()
	{
	}

	public override void Shutdown()
	{
	}

	public override int GetMaxPacketSize(int channelId = 0)
	{
		return 0;
	}

	public override int GetBatchThreshold(int channelId)
	{
		return 0;
	}

	public long GetAverageMaxSendRate()
	{
		return 0L;
	}

	public long GetAverageMaxReceiveRate()
	{
		return 0L;
	}

	private long GetTotalSendQueue()
	{
		return 0L;
	}

	private long GetTotalReceiveQueue()
	{
		return 0L;
	}

	private long GetTotalSendBuffer()
	{
		return 0L;
	}

	private long GetTotalReceiveBuffer()
	{
		return 0L;
	}

	public static string PrettyBytes(long bytes)
	{
		return null;
	}

	protected virtual void OnGUIStatistics()
	{
	}

	protected virtual void OnLogStatistics()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
