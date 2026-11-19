namespace Mirror.BouncyCastle.Tls;

public abstract class HeartbeatMode
{
	public const short peer_allowed_to_send = 1;

	public const short peer_not_allowed_to_send = 2;

	public static string GetName(short heartbeatMode)
	{
		return null;
	}

	public static string GetText(short heartbeatMode)
	{
		return null;
	}

	public static bool IsValid(short heartbeatMode)
	{
		return false;
	}
}
