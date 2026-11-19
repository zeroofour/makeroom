namespace Mirror.BouncyCastle.Asn1.Esf;

public class OcspResponsesID : Asn1Encodable
{
	private readonly OcspIdentifier m_ocspIdentifier;

	private readonly OtherHash m_ocspRepHash;

	public OcspIdentifier OcspIdentifier => null;

	public OtherHash OcspRepHash => null;

	public static OcspResponsesID GetInstance(object obj)
	{
		return null;
	}

	public static OcspResponsesID GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private OcspResponsesID(Asn1Sequence seq)
	{
	}

	public OcspResponsesID(OcspIdentifier ocspIdentifier)
	{
	}

	public OcspResponsesID(OcspIdentifier ocspIdentifier, OtherHash ocspRepHash)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
