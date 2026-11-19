using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Pkcs;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Crypto.Operators;

internal class X509Utilities
{
	private static readonly IDictionary<string, DerObjectIdentifier> m_algorithms;

	private static readonly IDictionary<string, Asn1Encodable> m_exParams;

	private static readonly HashSet<DerObjectIdentifier> noParams;

	static X509Utilities()
	{
	}

	private static string GetDigestAlgName(DerObjectIdentifier digestAlgOID)
	{
		return null;
	}

	internal static string GetSignatureName(AlgorithmIdentifier sigAlgId)
	{
		return null;
	}

	private static RsassaPssParameters CreatePssParams(AlgorithmIdentifier hashAlgId, int saltSize)
	{
		return null;
	}

	internal static DerObjectIdentifier GetAlgorithmOid(string algorithmName)
	{
		return null;
	}

	internal static AlgorithmIdentifier GetSigAlgID(DerObjectIdentifier sigOid, string algorithmName)
	{
		return null;
	}

	internal static IEnumerable<string> GetAlgNames()
	{
		return null;
	}
}
