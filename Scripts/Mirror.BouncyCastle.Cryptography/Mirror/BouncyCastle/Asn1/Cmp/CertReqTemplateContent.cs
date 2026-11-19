using Mirror.BouncyCastle.Asn1.Crmf;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class CertReqTemplateContent : Asn1Encodable
{
	private readonly CertTemplate m_certTemplate;

	private readonly Asn1Sequence m_keySpec;

	public virtual CertTemplate CertTemplate => null;

	public virtual Asn1Sequence KeySpec => null;

	public static CertReqTemplateContent GetInstance(object obj)
	{
		return null;
	}

	public static CertReqTemplateContent GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CertReqTemplateContent(Asn1Sequence seq)
	{
	}

	public CertReqTemplateContent(CertTemplate certTemplate, Asn1Sequence keySpec)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
