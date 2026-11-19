using System;
using System.Security.Authentication;
using UnityEngine;
using UnityEngine.Serialization;

namespace Mirror.SimpleWeb;

[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/manual/transports/websockets-transport")]
public class SimpleWebTransport : Transport, PortTransport
{
	public const string NormalScheme = "ws";

	public const string SecureScheme = "wss";

	[Tooltip("Protect against allocation attacks by keeping the max message size small. Otherwise an attacker might send multiple fake packets with 2GB headers, causing the server to run out of memory after allocating multiple large packets.")]
	public int maxMessageSize;

	[Tooltip("Max size for http header send as handshake for websockets")]
	[FormerlySerializedAs("handshakeMaxSize")]
	public int maxHandshakeSize;

	[FormerlySerializedAs("serverMaxMessagesPerTick")]
	[Tooltip("Caps the number of messages the server will process per tick. Allows LateUpdate to finish to let the reset of unity continue in case more messages arrive before they are processed")]
	public int serverMaxMsgsPerTick;

	[Tooltip("Caps the number of messages the client will process per tick. Allows LateUpdate to finish to let the reset of unity continue in case more messages arrive before they are processed")]
	[FormerlySerializedAs("clientMaxMessagesPerTick")]
	public int clientMaxMsgsPerTick;

	[Tooltip("Send would stall forever if the network is cut off during a send, so we need a timeout (in milliseconds)")]
	public int sendTimeout;

	[Tooltip("How long without a message before disconnecting (in milliseconds)")]
	public int receiveTimeout;

	[Tooltip("disables nagle algorithm. lowers CPU% and latency but increases bandwidth")]
	public bool noDelay;

	[Tooltip("Requires wss connections on server, only to be used with SSL cert.json, never with reverse proxy.\nNOTE: if sslEnabled is true clientUseWss is forced true, even if not checked.")]
	[Header("Obsolete SSL settings")]
	public bool sslEnabled;

	[Tooltip("Protocols that SSL certificate is created to support.")]
	public SslProtocols sslProtocols;

	[Tooltip("Path to json file that contains path to cert and its password\nUse Json file so that cert password is not included in client builds\nSee Assets/Mirror/Transports/.cert.example.Json")]
	public string sslCertJson;

	[Header("Server settings")]
	[Tooltip("Port to use for server")]
	public ushort port;

	[Tooltip("Groups messages in queue before calling Stream.Send")]
	public bool batchSend;

	[Tooltip("Waits for 1ms before grouping and sending messages.\nThis gives time for mirror to finish adding message to queue so that less groups need to be made.\nIf WaitBeforeSend is true then BatchSend Will also be set to true")]
	public bool waitBeforeSend;

	[Tooltip("Sets connect scheme to wss. Useful when client needs to connect using wss when TLS is outside of transport.\nNOTE: if sslEnabled is true clientUseWss is also true")]
	[Header("Client settings")]
	public bool clientUseWss;

	public ClientWebsocketSettings clientWebsocketSettings;

	[Header("Logging")]
	[SerializeField]
	[Tooltip("Choose minimum severity level for logging\nFlood level requires Debug build")]
	private Log.Levels minimumLogLevel;

	private SimpleWebClient client;

	private SimpleWebServer server;

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

	public Log.Levels LogLevels
	{
		get
		{
			return Log.Levels.Flood;
		}
		set
		{
		}
	}

	private TcpConfig TcpConfig => default;

	public override bool IsEncrypted => false;

	public override string EncryptionCipher => null;

	private void Awake()
	{
	}

	public override string ToString()
	{
		return null;
	}

	private void OnValidate()
	{
	}

	public override bool Available()
	{
		return false;
	}

	public override int GetMaxPacketSize(int channelId = 0)
	{
		return 0;
	}

	public override void Shutdown()
	{
	}

	private string GetClientScheme()
	{
		return null;
	}

	public override bool ClientConnected()
	{
		return false;
	}

	public override void ClientConnect(string hostname)
	{
	}

	public override void ClientConnect(Uri uri)
	{
	}

	public override void ClientDisconnect()
	{
	}

	public override void ClientSend(ArraySegment<byte> segment, int channelId)
	{
	}

	public override void ClientEarlyUpdate()
	{
	}

	private string GetServerScheme()
	{
		return null;
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

	public override void ServerStop()
	{
	}

	public override void ServerDisconnect(int connectionId)
	{
	}

	public override void ServerSend(int connectionId, ArraySegment<byte> segment, int channelId)
	{
	}

	public override string ServerGetClientAddress(int connectionId)
	{
		return null;
	}

	public Request ServerGetClientRequest(int connectionId)
	{
		return null;
	}

	public override void ServerEarlyUpdate()
	{
	}
}
