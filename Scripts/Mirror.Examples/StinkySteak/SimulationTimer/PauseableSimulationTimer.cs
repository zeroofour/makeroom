namespace StinkySteak.SimulationTimer;

public struct PauseableSimulationTimer
{
	private float _targetTime;

	private bool _isPaused;

	private float _pauseAtTime;

	public static PauseableSimulationTimer None => default;

	public float TargetTime => 0f;

	public bool IsPaused => false;

	public bool IsRunning => false;

	public float RemainingSeconds => 0f;

	private float GetTargetTime()
	{
		return 0f;
	}

	public static PauseableSimulationTimer CreateFromSeconds(float duration)
	{
		return default;
	}

	public void Pause()
	{
	}

	public void Resume()
	{
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
