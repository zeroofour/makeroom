namespace Mirror.BouncyCastle.Asn1.Cmp;

public class InfoTypeAndValue : Asn1Encodable
{
	private readonly DerObjectIdentifier m_infoType;

	private readonly Asn1Encodable m_infoValue;

	public virtual DerObjectIdentifier InfoType => null;

	public virtual Asn1Encodable InfoValue => null;

	public static InfoTypeAndValue GetInstance(object obj)
	{
		return null;
	}

	public static InfoTypeAndValue GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private InfoTypeAndValue(Asn1Sequence seq)
	{
	}

	public InfoTypeAndValue(DerObjectIdentifier infoType)
	{
	}

	public InfoTypeAndValue(DerObjectIdentifier infoType, Asn1Encodable infoValue)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
