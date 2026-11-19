using System;

namespace Mirror.BouncyCastle.Asn1.Ocsp;

public class CrlID : Asn1Encodable
{
	private readonly DerIA5String m_crlUrl;

	private readonly DerInteger m_crlNum;

	private readonly Asn1GeneralizedTime m_crlTime;

	public DerIA5String CrlUrl => null;

	public DerInteger CrlNum => null;

	public Asn1GeneralizedTime CrlTime => null;

	public static CrlID GetInstance(object obj)
	{
		return null;
	}

	public static CrlID GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	[Obsolete("Use 'GetInstance' instead")]
	public CrlID(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
