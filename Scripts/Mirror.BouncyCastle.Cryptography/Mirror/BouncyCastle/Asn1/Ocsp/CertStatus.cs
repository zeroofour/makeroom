namespace Mirror.BouncyCastle.Asn1.Ocsp;

public class CertStatus : Asn1Encodable, IAsn1Choice
{
	private readonly int m_tagNo;

	private readonly Asn1Encodable m_value;

	public int TagNo => 0;

	public Asn1Encodable Status => null;

	public static CertStatus GetInstance(object obj)
	{
		return null;
	}

	public static CertStatus GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private static Asn1Encodable GetValue(Asn1TaggedObject choice)
	{
		return null;
	}

	public CertStatus()
	{
	}

	public CertStatus(RevokedInfo info)
	{
	}

	public CertStatus(int tagNo, Asn1Encodable value)
	{
	}

	public CertStatus(Asn1TaggedObject choice)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
