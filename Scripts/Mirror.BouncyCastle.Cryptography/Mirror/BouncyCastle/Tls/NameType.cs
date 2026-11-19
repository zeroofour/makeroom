namespace Mirror.BouncyCastle.Tls;

public abstract class NameType
{
	public const short host_name = 0;

	public static string GetName(short nameType)
	{
		return null;
	}

	public static string GetText(short nameType)
	{
		return null;
	}

	public static bool IsRecognized(short nameType)
	{
		return false;
	}

	public static bool IsValid(short nameType)
	{
		return false;
	}
}
