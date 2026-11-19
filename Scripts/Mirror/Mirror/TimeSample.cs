using System.Diagnostics;

namespace Mirror;

public struct TimeSample(int n)
{
	private readonly Stopwatch watch = null;

	private double beginTime = 0.0;

	private ExponentialMovingAverage ema = default;

	public double average = 0.0;

	public void Begin()
	{
	}

	public void End()
	{
	}
}
