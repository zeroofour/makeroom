namespace Mirror;

internal struct ClientMainEvent(ClientMainEventType type, object param, int? channelId = null, TransportError? error = null)
{
	public ClientMainEventType type = ClientMainEventType.OnClientConnected;

	public object param = null;

	public int? channelId = null;

	public TransportError? error = null;
}
