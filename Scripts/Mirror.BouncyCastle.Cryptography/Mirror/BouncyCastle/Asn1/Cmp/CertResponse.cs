namespace Mirror.BouncyCastle.Asn1.Cmp;

public class CertResponse : Asn1Encodable
{
	private readonly DerInteger m_certReqId;

	private readonly PkiStatusInfo m_status;

	private readonly CertifiedKeyPair m_certifiedKeyPair;

	private readonly Asn1OctetString m_rspInfo;

	public virtual DerInteger CertReqID => null;

	public virtual PkiStatusInfo Status => null;

	public virtual CertifiedKeyPair CertifiedKeyPair => null;

	public virtual Asn1OctetString RspInfo => null;

	public static CertResponse GetInstance(object obj)
	{
		return null;
	}

	public static CertResponse GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CertResponse(Asn1Sequence seq)
	{
	}

	public CertResponse(DerInteger certReqId, PkiStatusInfo status)
	{
	}

	public CertResponse(DerInteger certReqId, PkiStatusInfo status, CertifiedKeyPair certifiedKeyPair, Asn1OctetString rspInfo)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
