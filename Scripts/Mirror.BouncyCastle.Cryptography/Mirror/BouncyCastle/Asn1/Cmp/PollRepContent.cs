namespace Mirror.BouncyCastle.Asn1.Cmp;

public class PollRepContent : Asn1Encodable
{
	private readonly DerInteger[] m_certReqID;

	private readonly DerInteger[] m_checkAfter;

	private readonly PkiFreeText[] m_reason;

	public virtual int Count => 0;

	public static PollRepContent GetInstance(object obj)
	{
		return null;
	}

	public static PollRepContent GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private PollRepContent(Asn1Sequence seq)
	{
	}

	public PollRepContent(DerInteger certReqID, DerInteger checkAfter)
	{
	}

	public PollRepContent(DerInteger certReqID, DerInteger checkAfter, PkiFreeText reason)
	{
	}

	public virtual DerInteger GetCertReqID(int index)
	{
		return null;
	}

	public virtual DerInteger GetCheckAfter(int index)
	{
		return null;
	}

	public virtual PkiFreeText GetReason(int index)
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
