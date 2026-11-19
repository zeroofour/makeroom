using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Ocsp;

internal class OcspUtilities
{
	private static readonly Dictionary<string, DerObjectIdentifier> Algorithms;

	private static readonly Dictionary<DerObjectIdentifier, string> Oids;

	private static readonly HashSet<DerObjectIdentifier> NoParams;

	internal static IEnumerable<string> AlgNames => null;

	static OcspUtilities()
	{
	}

	internal static DerObjectIdentifier GetAlgorithmOid(string algorithmName)
	{
		return null;
	}

	internal static string GetAlgorithmName(DerObjectIdentifier oid)
	{
		return null;
	}

	internal static AlgorithmIdentifier GetSigAlgID(DerObjectIdentifier sigOid)
	{
		return null;
	}
}
