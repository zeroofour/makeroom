using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Operators.Utilities;
using Mirror.BouncyCastle.Utilities.Collections;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cms;

internal static class CmsSignedHelper
{
	private static readonly Dictionary<DerObjectIdentifier, string> m_encryptionAlgs;

	private static readonly Dictionary<DerObjectIdentifier, string> m_digestAlgs;

	private static readonly Dictionary<string, string[]> m_digestAliases;

	private static readonly HashSet<DerObjectIdentifier> m_noParams;

	private static readonly Dictionary<string, DerObjectIdentifier> m_ecAlgorithms;

	private static void AddEntries(DerObjectIdentifier oid, string digest, string encryption)
	{
	}

	static CmsSignedHelper()
	{
	}

	internal static string GetDigestAlgName(DerObjectIdentifier digestOid)
	{
		return null;
	}

	internal static AlgorithmIdentifier GetEncAlgorithmIdentifier(DerObjectIdentifier encOid, Asn1Encodable sigX509Parameters)
	{
		return null;
	}

	internal static string[] GetDigestAliases(string algName)
	{
		return null;
	}

	internal static string GetEncryptionAlgName(DerObjectIdentifier encryptionOid)
	{
		return null;
	}

	internal static IDigest GetDigestInstance(string algorithm)
	{
		return null;
	}

	internal static ISigner GetSignatureInstance(string algorithm)
	{
		return null;
	}

	internal static AlgorithmIdentifier FixDigestAlgID(AlgorithmIdentifier algID, IDigestAlgorithmFinder digestAlgorithmFinder)
	{
		return null;
	}

	internal static DerObjectIdentifier GetEncOid(AsymmetricKeyParameter key, string digestOID)
	{
		return null;
	}

	internal static IStore<X509V2AttributeCertificate> GetAttributeCertificates(Asn1Set attrCertSet)
	{
		return null;
	}

	internal static IStore<X509Certificate> GetCertificates(Asn1Set certSet)
	{
		return null;
	}

	internal static IStore<X509Crl> GetCrls(Asn1Set crlSet)
	{
		return null;
	}

	internal static IStore<Asn1Encodable> GetOtherRevInfos(Asn1Set crlSet, DerObjectIdentifier infoFormat)
	{
		return null;
	}
}
