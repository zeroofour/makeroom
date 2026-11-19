namespace Mirror.BouncyCastle.Asn1.Cmp;

public class GenMsgContent : Asn1Encodable
{
	private readonly Asn1Sequence m_content;

	public static GenMsgContent GetInstance(object obj)
	{
		return null;
	}

	public static GenMsgContent GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private GenMsgContent(Asn1Sequence seq)
	{
	}

	public GenMsgContent(InfoTypeAndValue itv)
	{
	}

	public GenMsgContent(params InfoTypeAndValue[] itvs)
	{
	}

	public virtual InfoTypeAndValue[] ToInfoTypeAndValueArray()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
