namespace Mirror.BouncyCastle.Tls;

public class SignatureAlgorithm
{
	public const short anonymous = 0;

	public const short rsa = 1;

	public const short dsa = 2;

	public const short ecdsa = 3;

	public const short ed25519 = 7;

	public const short ed448 = 8;

	public const short rsa_pss_rsae_sha256 = 4;

	public const short rsa_pss_rsae_sha384 = 5;

	public const short rsa_pss_rsae_sha512 = 6;

	public const short rsa_pss_pss_sha256 = 9;

	public const short rsa_pss_pss_sha384 = 10;

	public const short rsa_pss_pss_sha512 = 11;

	public const short ecdsa_brainpoolP256r1tls13_sha256 = 26;

	public const short ecdsa_brainpoolP384r1tls13_sha384 = 27;

	public const short ecdsa_brainpoolP512r1tls13_sha512 = 28;

	public const short gostr34102012_256 = 64;

	public const short gostr34102012_512 = 65;

	public static short GetClientCertificateType(short signatureAlgorithm)
	{
		return 0;
	}

	public static string GetName(short signatureAlgorithm)
	{
		return null;
	}

	public static string GetText(short signatureAlgorithm)
	{
		return null;
	}

	public static bool IsRecognized(short signatureAlgorithm)
	{
		return false;
	}
}
