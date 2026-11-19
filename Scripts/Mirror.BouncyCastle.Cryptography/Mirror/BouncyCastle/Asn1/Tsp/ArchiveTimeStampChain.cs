namespace Mirror.BouncyCastle.Asn1.Tsp;

public class ArchiveTimeStampChain : Asn1Encodable
{
	private readonly Asn1Sequence m_archiveTimeStamps;

	public static ArchiveTimeStampChain GetInstance(object obj)
	{
		return null;
	}

	public static ArchiveTimeStampChain GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public ArchiveTimeStampChain(ArchiveTimeStamp archiveTimeStamp)
	{
	}

	public ArchiveTimeStampChain(ArchiveTimeStamp[] archiveTimeStamps)
	{
	}

	private ArchiveTimeStampChain(Asn1Sequence sequence)
	{
	}

	public virtual ArchiveTimeStamp[] GetArchiveTimestamps()
	{
		return null;
	}

	public virtual ArchiveTimeStampChain Append(ArchiveTimeStamp archiveTimeStamp)
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
