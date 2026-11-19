using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Tsp;

public class ArchiveTimeStamp : Asn1Encodable
{
	private readonly AlgorithmIdentifier m_digestAlgorithm;

	private readonly Attributes m_attributes;

	private readonly Asn1Sequence m_reducedHashTree;

	private readonly ContentInfo m_timeStamp;

	public virtual ContentInfo TimeStamp => null;

	public static ArchiveTimeStamp GetInstance(object obj)
	{
		return null;
	}

	public static ArchiveTimeStamp GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public ArchiveTimeStamp(AlgorithmIdentifier digestAlgorithm, PartialHashtree[] reducedHashTree, ContentInfo timeStamp)
	{
	}

	public ArchiveTimeStamp(ContentInfo timeStamp)
	{
	}

	public ArchiveTimeStamp(AlgorithmIdentifier digestAlgorithm, Attributes attributes, PartialHashtree[] reducedHashTree, ContentInfo timeStamp)
	{
	}

	private ArchiveTimeStamp(Asn1Sequence sequence)
	{
	}

	public virtual AlgorithmIdentifier GetDigestAlgorithmIdentifier()
	{
		return null;
	}

	public virtual byte[] GetTimeStampDigestValue()
	{
		return null;
	}

	private TstInfo GetTimeStampInfo()
	{
		return null;
	}

	public virtual AlgorithmIdentifier DigestAlgorithm()
	{
		return null;
	}

	public virtual PartialHashtree GetHashTreeLeaf()
	{
		return null;
	}

	public virtual PartialHashtree[] GetReducedHashTree()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
