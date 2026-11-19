namespace Mirror.BouncyCastle.Asn1.Cmp;

public class CertConfirmContent : Asn1Encodable
{
	private readonly Asn1Sequence m_content;

	public static CertConfirmContent GetInstance(object obj)
	{
		return null;
	}

	public static CertConfirmContent GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CertConfirmContent(Asn1Sequence seq)
	{
	}

	public virtual CertStatus[] ToCertStatusArray()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
