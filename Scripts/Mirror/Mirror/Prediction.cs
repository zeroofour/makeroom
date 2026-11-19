using System.Collections.Generic;

namespace Mirror;

public static class Prediction
{
	public static bool Sample<T>(SortedList<double, T> history, double timestamp, out T before, out T after, out int afterIndex, out double t)
	{
		before = default;
		after = default;
		afterIndex = default;
		t = default;
		return false;
	}

	public static T CorrectHistory<T>(SortedList<double, T> history, int stateHistoryLimit, T corrected, T before, T after, int afterIndex) where T : PredictedState
	{
		return default;
	}
}
