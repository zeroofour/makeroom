using System;

namespace Steamworks.Data;

public struct DurationControl
{
	internal DurationControl_t _inner;

	public AppId Appid => default;

	public bool Applicable => false;

	internal TimeSpan PlaytimeInLastFiveHours => default;

	internal TimeSpan PlaytimeToday => default;

	internal DurationControlProgress Progress => DurationControlProgress.Progress_Full;
}
