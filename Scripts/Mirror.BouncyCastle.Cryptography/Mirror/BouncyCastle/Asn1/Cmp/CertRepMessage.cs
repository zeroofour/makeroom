namespace Mirror.BouncyCastle.Asn1.Cmp;

public class CertRepMessage : Asn1Encodable
{
	private readonly Asn1Sequence m_caPubs;

	private readonly Asn1Sequence m_response;

	public static CertRepMessage GetInstance(object obj)
	{
		return null;
	}

	public static CertRepMessage GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CertRepMessage(Asn1Sequence seq)
	{
	}

	public CertRepMessage(CmpCertificate[] caPubs, CertResponse[] response)
	{
	}

	public virtual CmpCertificate[] GetCAPubs()
	{
		return null;
	}

	public virtual CertResponse[] GetResponse()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
