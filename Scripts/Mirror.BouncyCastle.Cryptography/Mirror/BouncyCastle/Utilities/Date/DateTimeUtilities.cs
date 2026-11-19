using System;

namespace Mirror.BouncyCastle.Utilities.Date;

public static class DateTimeUtilities
{
	public static readonly DateTime UnixEpoch;

	public static readonly long MaxUnixMs;

	public static readonly long MinUnixMs;

	public static long DateTimeToUnixMs(DateTime dateTime)
	{
		return 0L;
	}

	public static DateTime UnixMsToDateTime(long unixMs)
	{
		return default;
	}

	public static long CurrentUnixMs()
	{
		return 0L;
	}

	public static DateTime WithPrecisionCentisecond(DateTime dateTime)
	{
		return default;
	}

	public static DateTime WithPrecisionDecisecond(DateTime dateTime)
	{
		return default;
	}

	public static DateTime WithPrecisionMillisecond(DateTime dateTime)
	{
		return default;
	}

	public static DateTime WithPrecisionSecond(DateTime dateTime)
	{
		return default;
	}
}
