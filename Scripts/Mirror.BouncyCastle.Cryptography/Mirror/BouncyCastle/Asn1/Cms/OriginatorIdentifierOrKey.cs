using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cms;

public class OriginatorIdentifierOrKey : Asn1Encodable, IAsn1Choice
{
	private readonly Asn1Encodable m_id;

	public Asn1Encodable ID => null;

	public IssuerAndSerialNumber IssuerAndSerialNumber => null;

	public SubjectKeyIdentifier SubjectKeyIdentifier => null;

	public OriginatorPublicKey OriginatorPublicKey => null;

	public static OriginatorIdentifierOrKey GetInstance(object o)
	{
		return null;
	}

	public static OriginatorIdentifierOrKey GetInstance(Asn1TaggedObject o, bool explicitly)
	{
		return null;
	}

	public OriginatorIdentifierOrKey(IssuerAndSerialNumber id)
	{
	}

	public OriginatorIdentifierOrKey(SubjectKeyIdentifier id)
	{
	}

	public OriginatorIdentifierOrKey(OriginatorPublicKey id)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
