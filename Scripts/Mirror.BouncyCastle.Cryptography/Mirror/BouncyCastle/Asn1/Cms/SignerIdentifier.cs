namespace Mirror.BouncyCastle.Asn1.Cms;

public class SignerIdentifier : Asn1Encodable, IAsn1Choice
{
	private Asn1Encodable id;

	public bool IsTagged => false;

	public Asn1Encodable ID => null;

	public static SignerIdentifier GetInstance(object o)
	{
		return null;
	}

	public static SignerIdentifier GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public SignerIdentifier(IssuerAndSerialNumber id)
	{
	}

	public SignerIdentifier(Asn1OctetString id)
	{
	}

	public SignerIdentifier(Asn1Object id)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
