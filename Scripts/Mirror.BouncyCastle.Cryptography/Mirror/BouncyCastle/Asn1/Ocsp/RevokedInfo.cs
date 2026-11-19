using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Ocsp;

public class RevokedInfo : Asn1Encodable
{
	private readonly Asn1GeneralizedTime m_revocationTime;

	private readonly CrlReason m_revocationReason;

	public Asn1GeneralizedTime RevocationTime => null;

	public CrlReason RevocationReason => null;

	public static RevokedInfo GetInstance(object obj)
	{
		return null;
	}

	public static RevokedInfo GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	public RevokedInfo(Asn1GeneralizedTime revocationTime)
	{
	}

	public RevokedInfo(Asn1GeneralizedTime revocationTime, CrlReason revocationReason)
	{
	}

	private RevokedInfo(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
