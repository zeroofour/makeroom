using System.Collections.Generic;

namespace Mirror;

public static class LagCompensation
{
	public static void Insert<T>(Queue<KeyValuePair<double, T>> history, int historyLimit, double timestamp, T capture) where T : Capture
	{
	}

	public static bool Sample<T>(Queue<KeyValuePair<double, T>> history, double timestamp, double interval, out T before, out T after, out double t) where T : Capture
	{
		before = default;
		after = default;
		t = default;
		return false;
	}

	public static double EstimateTime(double serverTime, double rtt, double bufferTime)
	{
		return 0.0;
	}

	public static void DrawGizmos<T>(Queue<KeyValuePair<double, T>> history) where T : Capture
	{
	}
}
