namespace Mirror.BouncyCastle.Tls;

public abstract class CertChainType
{
	public const short individual_certs = 0;

	public const short pkipath = 1;

	public static string GetName(short certChainType)
	{
		return null;
	}

	public static string GetText(short certChainType)
	{
		return null;
	}

	public static bool IsValid(short certChainType)
	{
		return false;
	}
}
