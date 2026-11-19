namespace Mirror.BouncyCastle.Asn1.Esf;

public class CrlValidatedID : Asn1Encodable
{
	private readonly OtherHash m_crlHash;

	private readonly CrlIdentifier m_crlIdentifier;

	public OtherHash CrlHash => null;

	public CrlIdentifier CrlIdentifier => null;

	public static CrlValidatedID GetInstance(object obj)
	{
		return null;
	}

	public static CrlValidatedID GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CrlValidatedID(Asn1Sequence seq)
	{
	}

	public CrlValidatedID(OtherHash crlHash)
	{
	}

	public CrlValidatedID(OtherHash crlHash, CrlIdentifier crlIdentifier)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
