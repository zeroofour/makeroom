namespace Mirror;

internal struct ThreadEvent(ThreadEventType type, object param, int? connectionId = null, int? channelId = null)
{
	public ThreadEventType type = ThreadEventType.DoServerStart;

	public object param = null;

	public int? connectionId = null;

	public int? channelId = null;
}
