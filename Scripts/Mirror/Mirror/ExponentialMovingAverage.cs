namespace Mirror;

public struct ExponentialMovingAverage(int n)
{
	private readonly double alpha = 0.0;

	private bool initialized = false;

	public double Value = 0.0;

	public double Variance = 0.0;

	public double StandardDeviation = 0.0;

	public void Add(double newValue)
	{
	}

	public void Reset()
	{
	}
}
