namespace Mirror.BouncyCastle.Tls;

public abstract class HeartbeatMessageType
{
	public const short heartbeat_request = 1;

	public const short heartbeat_response = 2;

	public static string GetName(short heartbeatMessageType)
	{
		return null;
	}

	public static string GetText(short heartbeatMessageType)
	{
		return null;
	}

	public static bool IsValid(short heartbeatMessageType)
	{
		return false;
	}
}
