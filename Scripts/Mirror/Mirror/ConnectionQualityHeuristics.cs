using UnityEngine;

namespace Mirror;

public static class ConnectionQualityHeuristics
{
	public static Color ColorCode(this ConnectionQuality quality)
	{
		return default;
	}

	public static ConnectionQuality Simple(double rtt, double jitter)
	{
		return ConnectionQuality.ESTIMATING;
	}

	public static ConnectionQuality Pragmatic(double targetBufferTime, double currentBufferTime)
	{
		return ConnectionQuality.ESTIMATING;
	}
}
