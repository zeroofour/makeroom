namespace Mirror;

public struct TimeSnapshot : Snapshot
{
	public double remoteTime { get; set; } = 0.0;

	public double localTime { get; set; } = 0.0;

	public TimeSnapshot(double remoteTime, double localTime)
	{
	}
}
