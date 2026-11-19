namespace Mirror.BouncyCastle.Asn1.Cms;

public class RecipientIdentifier : Asn1Encodable, IAsn1Choice
{
	private readonly Asn1Encodable m_id;

	public bool IsTagged => false;

	public Asn1Encodable ID => null;

	public static RecipientIdentifier GetInstance(object o)
	{
		return null;
	}

	public static RecipientIdentifier GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public RecipientIdentifier(IssuerAndSerialNumber id)
	{
	}

	public RecipientIdentifier(Asn1OctetString id)
	{
	}

	public RecipientIdentifier(Asn1Object id)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
