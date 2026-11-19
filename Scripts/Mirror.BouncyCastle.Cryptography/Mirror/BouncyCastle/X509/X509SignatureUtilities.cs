using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.X509;

internal class X509SignatureUtilities
{
	internal static bool AreEquivalentAlgorithms(AlgorithmIdentifier id1, AlgorithmIdentifier id2)
	{
		return false;
	}

	private static string GetDigestAlgName(DerObjectIdentifier digestAlgOID)
	{
		return null;
	}

	internal static string GetSignatureName(AlgorithmIdentifier sigAlgID)
	{
		return null;
	}

	private static bool IsAbsentOrEmptyParameters(Asn1Encodable parameters)
	{
		return false;
	}
}
