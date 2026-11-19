namespace Mirror.BouncyCastle.Asn1.Pkcs;

public class CertBag : Asn1Encodable
{
	private readonly DerObjectIdentifier m_certID;

	private readonly Asn1Object m_certValue;

	public virtual DerObjectIdentifier CertID => null;

	public virtual Asn1Object CertValue => null;

	public static CertBag GetInstance(object obj)
	{
		return null;
	}

	private CertBag(Asn1Sequence seq)
	{
	}

	public CertBag(DerObjectIdentifier certID, Asn1Object certValue)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
