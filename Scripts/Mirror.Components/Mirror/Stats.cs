namespace Mirror;

internal struct Stats(int connections, double uptime, int configuredTickRate, int actualTickRate, long sentBytesPerSecond, long receiveBytesPerSecond, float serverTickInterval, double fullUpdateAvg, double serverEarlyAvg, double serverLateAvg, double transportEarlyAvg, double transportLateAvg)
{
	public int connections = 0;

	public double uptime = 0.0;

	public int configuredTickRate = 0;

	public int actualTickRate = 0;

	public long sentBytesPerSecond = 0L;

	public long receiveBytesPerSecond = 0L;

	public float serverTickInterval = 0f;

	public double fullUpdateAvg = 0.0;

	public double serverEarlyAvg = 0.0;

	public double serverLateAvg = 0.0;

	public double transportEarlyAvg = 0.0;

	public double transportLateAvg = 0.0;
}
