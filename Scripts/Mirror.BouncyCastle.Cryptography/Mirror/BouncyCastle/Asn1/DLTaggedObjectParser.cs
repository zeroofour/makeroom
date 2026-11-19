namespace Mirror.BouncyCastle.Asn1;

internal class DLTaggedObjectParser : BerTaggedObjectParser
{
	private readonly bool m_constructed;

	public override bool IsConstructed => false;

	internal DLTaggedObjectParser(int tagClass, int tagNo, bool constructed, Asn1StreamParser parser)
		: base(0, 0, null)
	{
	}

	public override IAsn1Convertible ParseBaseUniversal(bool declaredExplicit, int baseTagNo)
	{
		return null;
	}

	public override IAsn1Convertible ParseExplicitBaseObject()
	{
		return null;
	}

	public override Asn1TaggedObjectParser ParseExplicitBaseTagged()
	{
		return null;
	}

	public override Asn1TaggedObjectParser ParseImplicitBaseTagged(int baseTagClass, int baseTagNo)
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}

	private Asn1StreamParser CheckConstructed()
	{
		return null;
	}
}
