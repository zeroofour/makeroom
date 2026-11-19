namespace Mirror.BouncyCastle.Tls;

public abstract class PskKeyExchangeMode
{
	public const short psk_ke = 0;

	public const short psk_dhe_ke = 1;

	public static string GetName(short pskKeyExchangeMode)
	{
		return null;
	}

	public static string GetText(short pskKeyExchangeMode)
	{
		return null;
	}
}
