using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class OtherCertID : Asn1Encodable
{
	private readonly OtherHash m_otherCertHash;

	private readonly IssuerSerial m_issuerSerial;

	public OtherHash OtherCertHash => null;

	public IssuerSerial IssuerSerial => null;

	public static OtherCertID GetInstance(object obj)
	{
		return null;
	}

	public static OtherCertID GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private OtherCertID(Asn1Sequence seq)
	{
	}

	public OtherCertID(OtherHash otherCertHash)
	{
	}

	public OtherCertID(OtherHash otherCertHash, IssuerSerial issuerSerial)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
