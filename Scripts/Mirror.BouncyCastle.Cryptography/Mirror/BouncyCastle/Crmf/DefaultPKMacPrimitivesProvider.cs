using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Crmf;

public class DefaultPKMacPrimitivesProvider : IPKMacPrimitivesProvider
{
	public IDigest CreateDigest(AlgorithmIdentifier digestAlg)
	{
		return null;
	}

	public IMac CreateMac(AlgorithmIdentifier macAlg)
	{
		return null;
	}
}
