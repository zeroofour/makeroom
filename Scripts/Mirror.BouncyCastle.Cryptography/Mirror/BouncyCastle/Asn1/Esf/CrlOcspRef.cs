namespace Mirror.BouncyCastle.Asn1.Esf;

public class CrlOcspRef : Asn1Encodable
{
	private readonly CrlListID m_crlids;

	private readonly OcspListID m_ocspids;

	private readonly OtherRevRefs m_otherRev;

	public CrlListID CrlIDs => null;

	public OcspListID OcspIDs => null;

	public OtherRevRefs OtherRev => null;

	public static CrlOcspRef GetInstance(object obj)
	{
		return null;
	}

	public static CrlOcspRef GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CrlOcspRef(Asn1Sequence seq)
	{
	}

	public CrlOcspRef(CrlListID crlids, OcspListID ocspids, OtherRevRefs otherRev)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
