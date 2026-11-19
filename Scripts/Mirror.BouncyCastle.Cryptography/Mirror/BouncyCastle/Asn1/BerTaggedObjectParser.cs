namespace Mirror.BouncyCastle.Asn1;

internal class BerTaggedObjectParser : Asn1TaggedObjectParser, IAsn1Convertible
{
	internal readonly int m_tagClass;

	internal readonly int m_tagNo;

	internal readonly Asn1StreamParser m_parser;

	public virtual bool IsConstructed => false;

	public int TagClass => 0;

	public int TagNo => 0;

	internal BerTaggedObjectParser(int tagClass, int tagNo, Asn1StreamParser parser)
	{
	}

	public bool HasContextTag()
	{
		return false;
	}

	public bool HasContextTag(int tagNo)
	{
		return false;
	}

	public bool HasTag(int tagClass, int tagNo)
	{
		return false;
	}

	public bool HasTagClass(int tagClass)
	{
		return false;
	}

	public virtual IAsn1Convertible ParseBaseUniversal(bool declaredExplicit, int baseTagNo)
	{
		return null;
	}

	public virtual IAsn1Convertible ParseExplicitBaseObject()
	{
		return null;
	}

	public virtual Asn1TaggedObjectParser ParseExplicitBaseTagged()
	{
		return null;
	}

	public virtual Asn1TaggedObjectParser ParseImplicitBaseTagged(int baseTagClass, int baseTagNo)
	{
		return null;
	}

	public virtual Asn1Object ToAsn1Object()
	{
		return null;
	}
}
