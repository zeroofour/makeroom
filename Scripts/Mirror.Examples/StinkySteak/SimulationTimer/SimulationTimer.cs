namespace StinkySteak.SimulationTimer;

public struct SimulationTimer
{
	private float _targetTime;

	public static SimulationTimer None => default;

	public float TargetTime => 0f;

	public bool IsRunning => false;

	public float RemainingSeconds => 0f;

	public static SimulationTimer CreateFromSeconds(float duration)
	{
		return default;
	}

	public bool IsExpired()
	{
		return false;
	}

	public bool IsExpiredOrNotRunning()
	{
		return false;
	}
}
