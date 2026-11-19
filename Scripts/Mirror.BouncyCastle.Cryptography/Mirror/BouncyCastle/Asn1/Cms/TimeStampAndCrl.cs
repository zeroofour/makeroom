using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cms;

public class TimeStampAndCrl : Asn1Encodable
{
	private ContentInfo timeStamp;

	private CertificateList crl;

	public virtual ContentInfo TimeStampToken => null;

	public virtual CertificateList Crl => null;

	public static TimeStampAndCrl GetInstance(object obj)
	{
		return null;
	}

	public static TimeStampAndCrl GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public TimeStampAndCrl(ContentInfo timeStamp)
	{
	}

	private TimeStampAndCrl(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
