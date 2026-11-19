using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cms;

public class CmsAlgorithmProtection : Asn1Encodable
{
	public static readonly int Signature;

	public static readonly int Mac;

	private readonly AlgorithmIdentifier digestAlgorithm;

	private readonly AlgorithmIdentifier signatureAlgorithm;

	private readonly AlgorithmIdentifier macAlgorithm;

	public AlgorithmIdentifier DigestAlgorithm => null;

	public AlgorithmIdentifier MacAlgorithm => null;

	public AlgorithmIdentifier SignatureAlgorithm => null;

	public static CmsAlgorithmProtection GetInstance(object obj)
	{
		return null;
	}

	public static CmsAlgorithmProtection GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public CmsAlgorithmProtection(AlgorithmIdentifier digestAlgorithm, int type, AlgorithmIdentifier algorithmIdentifier)
	{
	}

	private CmsAlgorithmProtection(Asn1Sequence sequence)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
