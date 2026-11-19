namespace Mirror.BouncyCastle.Asn1.Cmp;

public class GenRepContent : Asn1Encodable
{
	private readonly Asn1Sequence m_content;

	public static GenRepContent GetInstance(object obj)
	{
		return null;
	}

	public static GenRepContent GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private GenRepContent(Asn1Sequence seq)
	{
	}

	public GenRepContent(InfoTypeAndValue itv)
	{
	}

	public GenRepContent(params InfoTypeAndValue[] itvs)
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
