namespace Mirror.BouncyCastle.Tls;

public abstract class ContentType
{
	public const short change_cipher_spec = 20;

	public const short alert = 21;

	public const short handshake = 22;

	public const short application_data = 23;

	public const short heartbeat = 24;

	public const short tls12_cid = 25;

	public static string GetName(short contentType)
	{
		return null;
	}

	public static string GetText(short contentType)
	{
		return null;
	}
}
