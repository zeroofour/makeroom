using System;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Ocsp;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Ocsp;

public class CertificateID : IEquatable<CertificateID>
{
	[Obsolete("Use 'OiwObjectIdentifiers.IdSha1.Id' instead")]
	public const string HashSha1 = "1.3.14.3.2.26";

	public static readonly AlgorithmIdentifier DigestSha1;

	private readonly CertID m_id;

	public string HashAlgOid => null;

	public BigInteger SerialNumber => null;

	public CertificateID(CertID id)
	{
	}

	[Obsolete("Will be removed")]
	public CertificateID(string hashAlgorithm, X509Certificate issuerCert, BigInteger serialNumber)
	{
	}

	public CertificateID(AlgorithmIdentifier digestAlgorithm, X509Certificate issuerCert, BigInteger serialNumber)
	{
	}

	public CertificateID(IDigestFactory digestFactory, X509Certificate issuerCert, BigInteger serialNumber)
	{
	}

	public byte[] GetIssuerNameHash()
	{
		return null;
	}

	public byte[] GetIssuerKeyHash()
	{
		return null;
	}

	public bool MatchesIssuer(X509Certificate issuerCert)
	{
		return false;
	}

	public bool MatchesIssuer(IDigestFactory digestFactory, X509Certificate issuerCert)
	{
		return false;
	}

	public CertID ToAsn1Object()
	{
		return null;
	}

	public bool Equals(CertificateID other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static CertificateID DeriveCertificateID(CertificateID original, BigInteger newSerialNumber)
	{
		return null;
	}

	private static CertID CreateCertID(AlgorithmIdentifier digestAlgorithm, X509Certificate issuerCert, DerInteger serialNumber)
	{
		return null;
	}

	private static CertID CreateCertID(IDigestFactory digestFactory, X509Certificate issuerCert, DerInteger serialNumber)
	{
		return null;
	}
}
