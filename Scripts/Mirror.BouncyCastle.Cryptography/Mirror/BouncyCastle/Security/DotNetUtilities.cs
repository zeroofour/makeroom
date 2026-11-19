using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Mirror.BouncyCastle.Asn1.Pkcs;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Asn1.X9;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Math.EC;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Security;

public static class DotNetUtilities
{
	public static System.Security.Cryptography.X509Certificates.X509Certificate ToX509Certificate(X509CertificateStructure x509Struct)
	{
		return null;
	}

	public static System.Security.Cryptography.X509Certificates.X509Certificate ToX509Certificate(Mirror.BouncyCastle.X509.X509Certificate x509Cert)
	{
		return null;
	}

	public static Mirror.BouncyCastle.X509.X509Certificate FromX509Certificate(System.Security.Cryptography.X509Certificates.X509Certificate x509Cert)
	{
		return null;
	}

	public static AsymmetricCipherKeyPair GetDsaKeyPair(DSA dsa)
	{
		return null;
	}

	public static AsymmetricCipherKeyPair GetDsaKeyPair(DSAParameters dp)
	{
		return null;
	}

	public static DsaPublicKeyParameters GetDsaPublicKey(DSA dsa)
	{
		return null;
	}

	public static DsaPublicKeyParameters GetDsaPublicKey(DSAParameters dp)
	{
		return null;
	}

	public static AsymmetricCipherKeyPair GetECDsaKeyPair(ECDsa ecDsa)
	{
		return null;
	}

	public static ECPublicKeyParameters GetECDsaPublicKey(ECDsa ecDsa)
	{
		return null;
	}

	public static AsymmetricCipherKeyPair GetECKeyPair(string algorithm, ECParameters ec)
	{
		return null;
	}

	public static ECPublicKeyParameters GetECPublicKey(string algorithm, ECParameters ec)
	{
		return null;
	}

	private static Mirror.BouncyCastle.Math.EC.ECPoint GetECPoint(Mirror.BouncyCastle.Math.EC.ECCurve curve, System.Security.Cryptography.ECPoint point)
	{
		return null;
	}

	private static X9ECParameters GetX9ECParameters(System.Security.Cryptography.ECCurve curve)
	{
		return null;
	}

	public static AsymmetricCipherKeyPair GetRsaKeyPair(RSA rsa)
	{
		return null;
	}

	public static AsymmetricCipherKeyPair GetRsaKeyPair(RSAParameters rp)
	{
		return null;
	}

	public static RsaKeyParameters GetRsaPublicKey(RSA rsa)
	{
		return null;
	}

	public static RsaKeyParameters GetRsaPublicKey(RSAParameters rp)
	{
		return null;
	}

	public static AsymmetricCipherKeyPair GetKeyPair(AsymmetricAlgorithm privateKey)
	{
		return null;
	}

	public static RSA ToRSA(RsaKeyParameters rsaKey)
	{
		return null;
	}

	public static RSA ToRSA(RsaKeyParameters rsaKey, CspParameters csp)
	{
		return null;
	}

	public static RSA ToRSA(RsaPrivateCrtKeyParameters privKey)
	{
		return null;
	}

	public static RSA ToRSA(RsaPrivateCrtKeyParameters privKey, CspParameters csp)
	{
		return null;
	}

	public static RSA ToRSA(RsaPrivateKeyStructure privKey)
	{
		return null;
	}

	public static RSA ToRSA(RsaPrivateKeyStructure privKey, CspParameters csp)
	{
		return null;
	}

	public static RSAParameters ToRSAParameters(RsaKeyParameters rsaKey)
	{
		return default;
	}

	public static RSAParameters ToRSAParameters(RsaPrivateCrtKeyParameters privKey)
	{
		return default;
	}

	public static RSAParameters ToRSAParameters(RsaPrivateKeyStructure privKey)
	{
		return default;
	}

	private static byte[] ConvertRSAParametersField(BigInteger n, int size)
	{
		return null;
	}

	private static RSACryptoServiceProvider CreateRSAProvider(RSAParameters rp)
	{
		return null;
	}

	private static RSACryptoServiceProvider CreateRSAProvider(RSAParameters rp, CspParameters csp)
	{
		return null;
	}
}
