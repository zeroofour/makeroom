namespace Mirror.BouncyCastle.Tls;

public abstract class PrfAlgorithm
{
	public const int ssl_prf_legacy = 0;

	public const int tls_prf_legacy = 1;

	public const int tls_prf_sha256 = 2;

	public const int tls_prf_sha384 = 3;

	public const int tls13_hkdf_sha256 = 4;

	public const int tls13_hkdf_sha384 = 5;

	public const int tls13_hkdf_sm3 = 7;

	public const int tls_prf_gostr3411_2012_256 = 8;

	public static string GetName(int prfAlgorithm)
	{
		return null;
	}

	public static string GetText(int prfAlgorithm)
	{
		return null;
	}
}
