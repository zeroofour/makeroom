using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Cms;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Tsp;

public class TspUtil
{
	private static readonly Dictionary<string, int> DigestLengths;

	private static readonly Dictionary<string, string> DigestNames;

	static TspUtil()
	{
	}

	public static IList<TimeStampToken> GetSignatureTimestamps(SignerInformation signerInfo)
	{
		return null;
	}

	public static void ValidateCertificate(X509Certificate cert)
	{
	}

	internal static string GetDigestAlgName(string digestAlgOid)
	{
		return null;
	}

	internal static int GetDigestLength(string digestAlgOid)
	{
		return 0;
	}

	internal static IDigest CreateDigestInstance(string digestAlgOID)
	{
		return null;
	}

	internal static HashSet<DerObjectIdentifier> GetCriticalExtensionOids(X509Extensions extensions)
	{
		return null;
	}

	internal static HashSet<DerObjectIdentifier> GetNonCriticalExtensionOids(X509Extensions extensions)
	{
		return null;
	}

	internal static IList<DerObjectIdentifier> GetExtensionOids(X509Extensions extensions)
	{
		return null;
	}
}
