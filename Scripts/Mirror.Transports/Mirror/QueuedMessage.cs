namespace Mirror;

internal struct QueuedMessage(int connectionId, byte[] bytes, double time, int channelId)
{
	public int connectionId = 0;

	public byte[] bytes = null;

	public double time = 0.0;

	public int channelId = 0;
}
