using System;
using Mirror.BouncyCastle.Asn1.Ocsp;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class OcspIdentifier : Asn1Encodable
{
	private readonly ResponderID m_ocspResponderID;

	private readonly Asn1GeneralizedTime m_producedAt;

	public ResponderID OcspResponderID => null;

	public Asn1GeneralizedTime ProducedAtData => null;

	public DateTime ProducedAt => default;

	public static OcspIdentifier GetInstance(object obj)
	{
		return null;
	}

	public static OcspIdentifier GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private OcspIdentifier(Asn1Sequence seq)
	{
	}

	public OcspIdentifier(ResponderID ocspResponderID, DateTime producedAt)
	{
	}

	public OcspIdentifier(ResponderID ocspResponderID, Asn1GeneralizedTime producedAt)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
