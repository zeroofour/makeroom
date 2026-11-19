namespace Mirror.BouncyCastle.Tls;

public abstract class KeyUpdateRequest
{
	public const short update_not_requested = 0;

	public const short update_requested = 1;

	public static string GetName(short keyUpdateRequest)
	{
		return null;
	}

	public static string GetText(short keyUpdateRequest)
	{
		return null;
	}

	public static bool IsValid(short keyUpdateRequest)
	{
		return false;
	}
}
