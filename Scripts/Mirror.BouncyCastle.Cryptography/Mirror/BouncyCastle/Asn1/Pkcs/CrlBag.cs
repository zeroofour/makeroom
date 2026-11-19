namespace Mirror.BouncyCastle.Asn1.Pkcs;

public class CrlBag : Asn1Encodable
{
	private readonly DerObjectIdentifier m_crlID;

	private readonly Asn1Encodable m_crlValue;

	public virtual DerObjectIdentifier CrlID => null;

	public virtual Asn1Encodable CrlValue => null;

	public static CrlBag GetInstance(object obj)
	{
		return null;
	}

	private CrlBag(Asn1Sequence seq)
	{
	}

	public CrlBag(DerObjectIdentifier crlID, Asn1Encodable crlValue)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
