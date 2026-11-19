using System;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class OtherRevVals : Asn1Encodable
{
	private readonly DerObjectIdentifier m_otherRevValType;

	private readonly Asn1Encodable m_otherRevVals;

	public DerObjectIdentifier OtherRevValType => null;

	public Asn1Encodable OtherRevValsData => null;

	[Obsolete("Use 'OtherRevValsData' instead")]
	public Asn1Object OtherRevValsObject => null;

	public static OtherRevVals GetInstance(object obj)
	{
		return null;
	}

	public static OtherRevVals GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	private OtherRevVals(Asn1Sequence seq)
	{
	}

	public OtherRevVals(DerObjectIdentifier otherRevValType, Asn1Encodable otherRevVals)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
