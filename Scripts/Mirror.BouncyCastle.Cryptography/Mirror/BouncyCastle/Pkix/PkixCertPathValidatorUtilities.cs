using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.X509;
using Mirror.BouncyCastle.X509.Store;

namespace Mirror.BouncyCastle.Pkix;

internal static class PkixCertPathValidatorUtilities
{
	private static readonly PkixCrlUtilities CrlUtilities;

	internal static readonly string ANY_POLICY;

	internal static readonly string CRL_NUMBER;

	internal static readonly int KEY_CERT_SIGN;

	internal static readonly int CRL_SIGN;

	internal static TrustAnchor FindTrustAnchor(X509Certificate cert, ISet<TrustAnchor> trustAnchors)
	{
		return null;
	}

	internal static bool IsIssuerTrustAnchor(X509Certificate cert, ISet<TrustAnchor> trustAnchors)
	{
		return false;
	}

	internal static void AddAdditionalStoresFromAltNames(X509Certificate cert, PkixParameters pkixParams)
	{
	}

	internal static DateTime GetValidDate(PkixParameters paramsPKIX)
	{
		return default;
	}

	internal static X509Name GetIssuerPrincipal(object obj)
	{
		return null;
	}

	internal static X509Name GetIssuerPrincipal(X509V2AttributeCertificate attrCert)
	{
		return null;
	}

	internal static X509Name GetIssuerPrincipal(X509Certificate cert)
	{
		return null;
	}

	internal static bool IsSelfIssued(X509Certificate cert)
	{
		return false;
	}

	internal static AlgorithmIdentifier GetAlgorithmIdentifier(AsymmetricKeyParameter key)
	{
		return null;
	}

	internal static bool IsAnyPolicy(ISet<string> policySet)
	{
		return false;
	}

	internal static void AddAdditionalStoreFromLocation(string location, PkixParameters pkixParams)
	{
	}

	private static BigInteger GetSerialNumber(object cert)
	{
		return null;
	}

	internal static HashSet<PolicyQualifierInfo> GetQualifierSet(Asn1Sequence qualifiers)
	{
		return null;
	}

	internal static PkixPolicyNode RemovePolicyNode(PkixPolicyNode validPolicyTree, IList<PkixPolicyNode>[] policyNodes, PkixPolicyNode _node)
	{
		return null;
	}

	private static void RemovePolicyNodeRecurse(IList<PkixPolicyNode>[] policyNodes, PkixPolicyNode _node)
	{
	}

	internal static void PrepareNextCertB1(int i, IList<PkixPolicyNode>[] policyNodes, string id_p, IDictionary<string, HashSet<string>> m_idp, X509Certificate cert)
	{
	}

	internal static PkixPolicyNode PrepareNextCertB2(int i, IList<PkixPolicyNode>[] policyNodes, string id_p, PkixPolicyNode validPolicyTree)
	{
		return null;
	}

	internal static void GetCertStatus(DateTime validDate, X509Crl crl, object cert, CertStatus certStatus)
	{
	}

	internal static AsymmetricKeyParameter GetNextWorkingKey(IList<X509Certificate> certs, int index)
	{
		return null;
	}

	internal static DateTime GetValidCertDateFromValidityModel(PkixParameters paramsPkix, PkixCertPath certPath, int index)
	{
		return default;
	}

	internal static void GetCrlIssuersFromDistributionPoint(DistributionPoint dp, ICollection<X509Name> issuerPrincipals, X509CrlStoreSelector selector, PkixParameters pkixParameters)
	{
	}

	internal static ISet<X509Crl> GetCompleteCrls(DistributionPoint dp, object certObj, DateTime currentDate, PkixParameters pkixParameters)
	{
		return null;
	}

	internal static HashSet<X509Crl> GetDeltaCrls(DateTime currentDate, PkixParameters pkixParameters, X509Crl completeCRL)
	{
		return null;
	}

	private static bool IsDeltaCrl(X509Crl crl)
	{
		return false;
	}

	internal static void AddAdditionalStoresFromCrlDistributionPoint(CrlDistPoint crldp, PkixParameters pkixParams)
	{
	}

	internal static bool ProcessCertD1i(int index, IList<PkixPolicyNode>[] policyNodes, DerObjectIdentifier pOid, HashSet<PolicyQualifierInfo> pq)
	{
		return false;
	}

	internal static void ProcessCertD1ii(int index, IList<PkixPolicyNode>[] policyNodes, DerObjectIdentifier _poid, HashSet<PolicyQualifierInfo> _pq)
	{
	}

	internal static HashSet<X509Certificate> FindIssuerCerts(X509Certificate cert, PkixBuilderParameters pkixBuilderParameters)
	{
		return null;
	}

	internal static Asn1Object GetExtensionValue(IX509Extension extensions, DerObjectIdentifier oid)
	{
		return null;
	}
}
