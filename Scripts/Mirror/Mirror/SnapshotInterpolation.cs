using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Mirror;

public static class SnapshotInterpolation
{
	public static double Timescale(double drift, double catchupSpeed, double slowdownSpeed, double absoluteCatchupNegativeThreshold, double absoluteCatchupPositiveThreshold)
	{
		return 0.0;
	}

	public static double DynamicAdjustment(double sendInterval, double jitterStandardDeviation, double dynamicAdjustmentTolerance)
	{
		return 0.0;
	}

	public static bool InsertIfNotExists<T>(SortedList<double, T> buffer, int bufferLimit, T snapshot) where T : Snapshot
	{
		return false;
	}

	public static double TimelineClamp(double localTimeline, double bufferTime, double latestRemoteTime)
	{
		return 0.0;
	}

	public static void InsertAndAdjust<T>(SortedList<double, T> buffer, int bufferLimit, T snapshot, ref double localTimeline, ref double localTimescale, float sendInterval, double bufferTime, double catchupSpeed, double slowdownSpeed, ref ExponentialMovingAverage driftEma, float catchupNegativeThreshold, float catchupPositiveThreshold, ref ExponentialMovingAverage deliveryTimeEma) where T : Snapshot
	{
	}

	public static void Sample<T>(SortedList<double, T> buffer, double localTimeline, out int from, out int to, out double t) where T : Snapshot
	{
		from = default;
		to = default;
		t = default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void StepTime(double deltaTime, ref double localTimeline, double localTimescale)
	{
	}

	public static void StepInterpolation<T>(SortedList<double, T> buffer, double localTimeline, out T fromSnapshot, out T toSnapshot, out double t) where T : Snapshot
	{
		fromSnapshot = default;
		toSnapshot = default;
		t = default;
	}

	public static void Step<T>(SortedList<double, T> buffer, double deltaTime, ref double localTimeline, double localTimescale, out T fromSnapshot, out T toSnapshot, out double t) where T : Snapshot
	{
		fromSnapshot = default;
		toSnapshot = default;
		t = default;
	}
}
