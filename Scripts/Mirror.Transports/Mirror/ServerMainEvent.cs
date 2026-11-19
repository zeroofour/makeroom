namespace Mirror;

internal struct ServerMainEvent(ServerMainEventType type, object param, int? connectionId, int? channelId = null, TransportError? error = null)
{
	public ServerMainEventType type = ServerMainEventType.OnServerConnected;

	public object param = null;

	public int? connectionId = null;

	public int? channelId = null;

	public TransportError? error = null;
}
