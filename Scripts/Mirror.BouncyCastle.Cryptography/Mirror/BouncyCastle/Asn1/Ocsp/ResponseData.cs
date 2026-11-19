using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Ocsp;

public class ResponseData : Asn1Encodable
{
	private static readonly DerInteger V1;

	private readonly DerInteger m_version;

	private readonly bool m_versionPresent;

	private readonly ResponderID m_responderID;

	private readonly Asn1GeneralizedTime m_producedAt;

	private readonly Asn1Sequence m_responses;

	private readonly X509Extensions m_responseExtensions;

	public DerInteger Version => null;

	public ResponderID ResponderID => null;

	public Asn1GeneralizedTime ProducedAt => null;

	public Asn1Sequence Responses => null;

	public X509Extensions ResponseExtensions => null;

	public static ResponseData GetInstance(object obj)
	{
		return null;
	}

	public static ResponseData GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	public ResponseData(ResponderID responderID, Asn1GeneralizedTime producedAt, Asn1Sequence responses, X509Extensions responseExtensions)
	{
	}

	public ResponseData(DerInteger version, ResponderID responderID, Asn1GeneralizedTime producedAt, Asn1Sequence responses, X509Extensions responseExtensions)
	{
	}

	private ResponseData(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
