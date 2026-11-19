namespace Mirror.BouncyCastle.Tls;

public abstract class AlertLevel
{
	public const short warning = 1;

	public const short fatal = 2;

	public static string GetName(short alertDescription)
	{
		return null;
	}

	public static string GetText(short alertDescription)
	{
		return null;
	}
}
