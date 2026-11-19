namespace Mirror.BouncyCastle.Asn1.Cms;

public class OtherRecipientInfo : Asn1Encodable
{
	private readonly DerObjectIdentifier oriType;

	private readonly Asn1Encodable oriValue;

	public virtual DerObjectIdentifier OriType => null;

	public virtual Asn1Encodable OriValue => null;

	public static OtherRecipientInfo GetInstance(object obj)
	{
		return null;
	}

	public static OtherRecipientInfo GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	public OtherRecipientInfo(DerObjectIdentifier oriType, Asn1Encodable oriValue)
	{
	}

	private OtherRecipientInfo(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
