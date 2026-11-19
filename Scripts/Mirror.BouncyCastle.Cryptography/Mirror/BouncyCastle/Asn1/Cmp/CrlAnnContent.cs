using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class CrlAnnContent : Asn1Encodable
{
	private readonly Asn1Sequence m_content;

	public static CrlAnnContent GetInstance(object obj)
	{
		return null;
	}

	public static CrlAnnContent GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CrlAnnContent(Asn1Sequence seq)
	{
	}

	public CrlAnnContent(CertificateList crl)
	{
	}

	public virtual CertificateList[] ToCertificateListArray()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
