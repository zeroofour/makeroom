namespace Mirror.BouncyCastle.Asn1.Cms;

public class Attributes : Asn1Encodable
{
	private readonly Asn1Set m_attributes;

	public static Attributes GetInstance(object obj)
	{
		return null;
	}

	public static Attributes GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private Attributes(Asn1Set attributes)
	{
	}

	public Attributes(Asn1EncodableVector v)
	{
	}

	public virtual Attribute[] GetAttributes()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
