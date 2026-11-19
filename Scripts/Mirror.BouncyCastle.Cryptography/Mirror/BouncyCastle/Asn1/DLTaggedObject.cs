namespace Mirror.BouncyCastle.Asn1;

public class DLTaggedObject : DerTaggedObject
{
	public DLTaggedObject(int tagNo, Asn1Encodable obj)
		: base(0, null)
	{
	}

	public DLTaggedObject(int tagClass, int tagNo, Asn1Encodable obj)
		: base(0, null)
	{
	}

	public DLTaggedObject(bool isExplicit, int tagNo, Asn1Encodable obj)
		: base(0, null)
	{
	}

	public DLTaggedObject(bool isExplicit, int tagClass, int tagNo, Asn1Encodable obj)
		: base(0, null)
	{
	}

	internal DLTaggedObject(int explicitness, int tagClass, int tagNo, Asn1Encodable obj)
		: base(0, null)
	{
	}

	internal override IAsn1Encoding GetEncoding(int encoding)
	{
		return null;
	}

	internal override IAsn1Encoding GetEncodingImplicit(int encoding, int tagClass, int tagNo)
	{
		return null;
	}

	internal override Asn1Sequence RebuildConstructed(Asn1Object asn1Object)
	{
		return null;
	}

	internal override Asn1TaggedObject ReplaceTag(int tagClass, int tagNo)
	{
		return null;
	}
}
