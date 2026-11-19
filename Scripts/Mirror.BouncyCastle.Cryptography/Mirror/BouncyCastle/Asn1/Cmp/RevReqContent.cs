namespace Mirror.BouncyCastle.Asn1.Cmp;

public class RevReqContent : Asn1Encodable
{
	private readonly Asn1Sequence m_content;

	public static RevReqContent GetInstance(object obj)
	{
		return null;
	}

	public static RevReqContent GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private RevReqContent(Asn1Sequence seq)
	{
	}

	public RevReqContent(RevDetails revDetails)
	{
	}

	public RevReqContent(params RevDetails[] revDetailsArray)
	{
	}

	public virtual RevDetails[] ToRevDetailsArray()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
