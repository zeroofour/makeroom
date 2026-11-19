namespace Mirror.BouncyCastle.Tls;

public abstract class SignatureScheme
{
	public const int rsa_pkcs1_sha1 = 513;

	public const int ecdsa_sha1 = 515;

	public const int rsa_pkcs1_sha256 = 1025;

	public const int rsa_pkcs1_sha384 = 1281;

	public const int rsa_pkcs1_sha512 = 1537;

	public const int ecdsa_secp256r1_sha256 = 1027;

	public const int ecdsa_secp384r1_sha384 = 1283;

	public const int ecdsa_secp521r1_sha512 = 1539;

	public const int rsa_pss_rsae_sha256 = 2052;

	public const int rsa_pss_rsae_sha384 = 2053;

	public const int rsa_pss_rsae_sha512 = 2054;

	public const int ed25519 = 2055;

	public const int ed448 = 2056;

	public const int rsa_pss_pss_sha256 = 2057;

	public const int rsa_pss_pss_sha384 = 2058;

	public const int rsa_pss_pss_sha512 = 2059;

	public const int ecdsa_brainpoolP256r1tls13_sha256 = 2074;

	public const int ecdsa_brainpoolP384r1tls13_sha384 = 2075;

	public const int ecdsa_brainpoolP512r1tls13_sha512 = 2076;

	public const int sm2sig_sm3 = 1800;

	public static int From(SignatureAndHashAlgorithm sigAndHashAlg)
	{
		return 0;
	}

	public static int From(short hashAlgorithm, short signatureAlgorithm)
	{
		return 0;
	}

	public static int GetCryptoHashAlgorithm(int signatureScheme)
	{
		return 0;
	}

	public static int GetCryptoHashAlgorithm(SignatureAndHashAlgorithm signatureAndHashAlgorithm)
	{
		return 0;
	}

	public static string GetName(int signatureScheme)
	{
		return null;
	}

	public static int GetNamedGroup(int signatureScheme)
	{
		return 0;
	}

	public static short GetHashAlgorithm(int signatureScheme)
	{
		return 0;
	}

	public static short GetSignatureAlgorithm(int signatureScheme)
	{
		return 0;
	}

	public static SignatureAndHashAlgorithm GetSignatureAndHashAlgorithm(int signatureScheme)
	{
		return null;
	}

	public static string GetText(int signatureScheme)
	{
		return null;
	}

	public static bool IsPrivate(int signatureScheme)
	{
		return false;
	}

	public static bool IsECDsa(int signatureScheme)
	{
		return false;
	}

	public static bool IsRsaPss(int signatureScheme)
	{
		return false;
	}
}
