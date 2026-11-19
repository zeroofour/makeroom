namespace Mirror.BouncyCastle.Asn1.Cmp;

public class RootCaKeyUpdateContent : Asn1Encodable
{
	private readonly CmpCertificate m_newWithNew;

	private readonly CmpCertificate m_newWithOld;

	private readonly CmpCertificate m_oldWithNew;

	public virtual CmpCertificate NewWithNew => null;

	public virtual CmpCertificate NewWithOld => null;

	public virtual CmpCertificate OldWithNew => null;

	public static RootCaKeyUpdateContent GetInstance(object obj)
	{
		return null;
	}

	public static RootCaKeyUpdateContent GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public RootCaKeyUpdateContent(CmpCertificate newWithNew, CmpCertificate newWithOld, CmpCertificate oldWithNew)
	{
	}

	private RootCaKeyUpdateContent(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
