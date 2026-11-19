using Mirror.BouncyCastle.Asn1.Tsp;

namespace Mirror.BouncyCastle.Asn1.Cms;

public class Evidence : Asn1Encodable, IAsn1Choice
{
	private readonly TimeStampTokenEvidence m_tstEvidence;

	private readonly EvidenceRecord m_ersEvidence;

	private readonly Asn1Sequence m_otherEvidence;

	public virtual TimeStampTokenEvidence TstEvidence => null;

	public virtual EvidenceRecord ErsEvidence => null;

	public static Evidence GetInstance(object obj)
	{
		return null;
	}

	public static Evidence GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		return null;
	}

	public Evidence(TimeStampTokenEvidence tstEvidence)
	{
	}

	public Evidence(EvidenceRecord ersEvidence)
	{
	}

	private Evidence(Asn1TaggedObject tagged)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
