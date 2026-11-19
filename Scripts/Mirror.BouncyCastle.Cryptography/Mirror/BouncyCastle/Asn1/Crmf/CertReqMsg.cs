using System;

namespace Mirror.BouncyCastle.Asn1.Crmf;

public class CertReqMsg : Asn1Encodable
{
	private readonly CertRequest m_certReq;

	private readonly ProofOfPossession m_pop;

	private readonly Asn1Sequence m_regInfo;

	public virtual CertRequest CertReq => null;

	public virtual ProofOfPossession Pop => null;

	[Obsolete("Use 'Pop' instead")]
	public virtual ProofOfPossession Popo => null;

	public static CertReqMsg GetInstance(object obj)
	{
		return null;
	}

	public static CertReqMsg GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		return null;
	}

	private CertReqMsg(Asn1Sequence seq)
	{
	}

	public CertReqMsg(CertRequest certReq, ProofOfPossession popo, AttributeTypeAndValue[] regInfo)
	{
	}

	public virtual AttributeTypeAndValue[] GetRegInfo()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
