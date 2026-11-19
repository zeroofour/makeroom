namespace Mirror.BouncyCastle.Asn1.X509;

public class PrivateKeyUsagePeriod : Asn1Encodable
{
	private Asn1GeneralizedTime _notBefore;

	private Asn1GeneralizedTime _notAfter;

	public Asn1GeneralizedTime NotBefore => null;

	public Asn1GeneralizedTime NotAfter => null;

	public static PrivateKeyUsagePeriod GetInstance(object obj)
	{
		return null;
	}

	private PrivateKeyUsagePeriod(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
