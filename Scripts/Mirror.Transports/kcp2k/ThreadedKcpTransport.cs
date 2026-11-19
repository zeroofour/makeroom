using System;
using Mirror;
using UnityEngine;
using UnityEngine.Serialization;

namespace kcp2k;

[HelpURL("https://mirror-networking.gitbook.io/docs/transports/kcp-transport")]
[DisallowMultipleComponent]
public class ThreadedKcpTransport : ThreadedTransport, PortTransport
{
	public const string Scheme = "kcp";

	[FormerlySerializedAs("Port")]
	[Header("Transport Configuration")]
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

	[Tooltip("KCP fastresend parameter. Faster resend for the cost of higher bandwidth. 0 in normal mode, 2 in turbo mode.")]
	[Header("Advanced")]
	public int FastResend;

	[Tooltip("KCP congestion window. Restricts window size to reduce congestion. Results in only 2-3 MTU messages per Flush even on loopback. Best to keept his disabled.")]
	private bool CongestionWindow;

	[Tooltip("KCP window size can be modified to support higher loads. This also increases max message size.")]
	public uint ReceiveWindowSize;

	[Tooltip("KCP window size can be modified to support higher loads.")]
	public uint SendWindowSize;

	[Tooltip("KCP will try to retransmit lost messages up to MaxRetransmit (aka dead_link) before disconnecting.")]
	public uint MaxRetransmit;

	[Tooltip("Enable to automatically set client & server send/recv buffers to OS limit. Avoids issues with too small buffers under heavy load, potentially dropping connections. Increase the OS limit if this is still too small.")]
	[FormerlySerializedAs("MaximizeSendReceiveBuffersToOSLimit")]
	public bool MaximizeSocketBuffers;

	[ReadOnly]
	[Tooltip("KCP reliable max message size shown for convenience. Can be changed via ReceiveWindowSize.")]
	[Header("Allowed Max Message Sizes\nBased on Receive Window Size")]
	public int ReliableMaxMessageSize;

	[ReadOnly]
	[Tooltip("KCP unreliable channel max message size for convenience. Not changeable.")]
	public int UnreliableMaxMessageSize;

	protected KcpConfig config;

	private const int MTU = 1200;

	protected KcpServer server;

	protected KcpClient client;

	private bool enabledCopy;

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

	protected override void Awake()
	{
	}

	protected virtual void OnValidate()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override bool Available()
	{
		return false;
	}

	protected override void ThreadedClientConnect(string address)
	{
	}

	protected override void ThreadedClientConnect(Uri uri)
	{
	}

	protected override void ThreadedClientSend(ArraySegment<byte> segment, int channelId)
	{
	}

	protected override void ThreadedClientDisconnect()
	{
	}

	protected override void ThreadedClientEarlyUpdate()
	{
	}

	protected override void ThreadedClientLateUpdate()
	{
	}

	public override Uri ServerUri()
	{
		return null;
	}

	protected override void ThreadedServerStart()
	{
	}

	protected override void ThreadedServerSend(int connectionId, ArraySegment<byte> segment, int channelId)
	{
	}

	protected override void ThreadedServerDisconnect(int connectionId)
	{
	}

	protected override void ThreadedServerStop()
	{
	}

	protected override void ThreadedServerEarlyUpdate()
	{
	}

	protected override void ThreadedServerLateUpdate()
	{
	}

	protected override void ThreadedShutdown()
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
