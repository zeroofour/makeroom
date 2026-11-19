namespace Mirror.BouncyCastle.Asn1.Cmp;

public class CAKeyUpdAnnContent : Asn1Encodable
{
	private readonly CmpCertificate m_oldWithNew;

	private readonly CmpCertificate m_newWithOld;

	private readonly CmpCertificate m_newWithNew;

	public virtual CmpCertificate OldWithNew => null;

	public virtual CmpCertificate NewWithOld => null;

	public virtual CmpCertificate NewWithNew => null;

	public static CAKeyUpdAnnContent GetInstance(object obj)
	{
		return null;
	}

	public static CAKeyUpdAnnContent GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CAKeyUpdAnnContent(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
