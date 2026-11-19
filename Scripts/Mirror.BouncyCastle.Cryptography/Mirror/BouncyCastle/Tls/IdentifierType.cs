namespace Mirror.BouncyCastle.Tls;

public abstract class IdentifierType
{
	public const short pre_agreed = 0;

	public const short key_sha1_hash = 1;

	public const short x509_name = 2;

	public const short cert_sha1_hash = 3;

	public static string GetName(short identifierType)
	{
		return null;
	}

	public static string GetText(short identifierType)
	{
		return null;
	}
}
