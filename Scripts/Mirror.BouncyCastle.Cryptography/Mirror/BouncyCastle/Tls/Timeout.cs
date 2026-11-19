namespace Mirror.BouncyCastle.Tls;

internal class Timeout
{
	private long durationMillis;

	private long startMillis;

	internal Timeout(long durationMillis)
	{
	}

	internal Timeout(long durationMillis, long currentTimeMillis)
	{
	}

	internal long RemainingMillis(long currentTimeMillis)
	{
		return 0L;
	}

	internal static int ConstrainWaitMillis(int waitMillis, Timeout timeout, long currentTimeMillis)
	{
		return 0;
	}

	internal static Timeout ForWaitMillis(int waitMillis)
	{
		return null;
	}

	internal static Timeout ForWaitMillis(int waitMillis, long currentTimeMillis)
	{
		return null;
	}

	internal static int GetWaitMillis(Timeout timeout, long currentTimeMillis)
	{
		return 0;
	}

	internal static bool HasExpired(Timeout timeout)
	{
		return false;
	}

	internal static bool HasExpired(Timeout timeout, long currentTimeMillis)
	{
		return false;
	}
}
