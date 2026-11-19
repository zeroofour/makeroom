using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Operators.Utilities;

namespace Mirror.BouncyCastle.Cmp;

internal static class CmpUtilities
{
	internal static byte[] CalculateCertHash(Asn1Encodable asn1Encodable, AlgorithmIdentifier signatureAlgorithm, IDigestAlgorithmFinder digestAlgorithmFinder)
	{
		return null;
	}
}
