namespace Mirror.BouncyCastle.Asn1.Tsp;

public class ArchiveTimeStampSequence : Asn1Encodable
{
	private readonly Asn1Sequence m_archiveTimeStampChains;

	public virtual int Count => 0;

	public static ArchiveTimeStampSequence GetInstance(object obj)
	{
		return null;
	}

	public static ArchiveTimeStampSequence GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private ArchiveTimeStampSequence(Asn1Sequence sequence)
	{
	}

	public ArchiveTimeStampSequence(ArchiveTimeStampChain archiveTimeStampChain)
	{
	}

	public ArchiveTimeStampSequence(ArchiveTimeStampChain[] archiveTimeStampChains)
	{
	}

	public virtual ArchiveTimeStampChain[] GetArchiveTimeStampChains()
	{
		return null;
	}

	public virtual ArchiveTimeStampSequence Append(ArchiveTimeStampChain chain)
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
