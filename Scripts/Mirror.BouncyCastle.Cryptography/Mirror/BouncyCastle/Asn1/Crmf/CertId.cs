using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Crmf;

public class CertId : Asn1Encodable
{
	private readonly GeneralName m_issuer;

	private readonly DerInteger m_serialNumber;

	public virtual GeneralName Issuer => null;

	public virtual DerInteger SerialNumber => null;

	public static CertId GetInstance(object obj)
	{
		return null;
	}

	public static CertId GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		return null;
	}

	private CertId(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
