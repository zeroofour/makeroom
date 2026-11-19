namespace Mirror.BouncyCastle.Asn1.X509;

public class AttCertValidityPeriod : Asn1Encodable
{
	private readonly Asn1GeneralizedTime notBeforeTime;

	private readonly Asn1GeneralizedTime notAfterTime;

	public Asn1GeneralizedTime NotBeforeTime => null;

	public Asn1GeneralizedTime NotAfterTime => null;

	public static AttCertValidityPeriod GetInstance(object obj)
	{
		return null;
	}

	public static AttCertValidityPeriod GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	private AttCertValidityPeriod(Asn1Sequence seq)
	{
	}

	public AttCertValidityPeriod(Asn1GeneralizedTime notBeforeTime, Asn1GeneralizedTime notAfterTime)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
