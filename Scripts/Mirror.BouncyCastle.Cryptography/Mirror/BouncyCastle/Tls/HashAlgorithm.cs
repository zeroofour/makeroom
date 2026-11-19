namespace Mirror.BouncyCastle.Tls;

public abstract class HashAlgorithm
{
	public const short none = 0;

	public const short md5 = 1;

	public const short sha1 = 2;

	public const short sha224 = 3;

	public const short sha256 = 4;

	public const short sha384 = 5;

	public const short sha512 = 6;

	public const short Intrinsic = 8;

	public static string GetName(short hashAlgorithm)
	{
		return null;
	}

	public static int GetOutputSize(short hashAlgorithm)
	{
		return 0;
	}

	public static string GetText(short hashAlgorithm)
	{
		return null;
	}

	public static bool IsPrivate(short hashAlgorithm)
	{
		return false;
	}

	public static bool IsRecognized(short hashAlgorithm)
	{
		return false;
	}
}
