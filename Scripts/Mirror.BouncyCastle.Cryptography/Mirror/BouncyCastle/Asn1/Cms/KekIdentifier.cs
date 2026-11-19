using System;

namespace Mirror.BouncyCastle.Asn1.Cms;

public class KekIdentifier : Asn1Encodable
{
	private Asn1OctetString keyIdentifier;

	private Asn1GeneralizedTime date;

	private OtherKeyAttribute other;

	public Asn1OctetString KeyIdentifier => null;

	public Asn1GeneralizedTime Date => null;

	public OtherKeyAttribute Other => null;

	public static KekIdentifier GetInstance(object obj)
	{
		return null;
	}

	public static KekIdentifier GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	public KekIdentifier(byte[] keyIdentifier, Asn1GeneralizedTime date, OtherKeyAttribute other)
	{
	}

	[Obsolete("Use 'GetInstance' instead")]
	public KekIdentifier(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
