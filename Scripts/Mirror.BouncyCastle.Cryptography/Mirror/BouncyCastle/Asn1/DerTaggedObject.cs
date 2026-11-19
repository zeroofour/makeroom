namespace Mirror.BouncyCastle.Asn1;

public class DerTaggedObject : Asn1TaggedObject
{
	public DerTaggedObject(int tagNo, Asn1Encodable obj)
		: base(isExplicit: false, 0, null)
	{
	}

	public DerTaggedObject(int tagClass, int tagNo, Asn1Encodable obj)
		: base(isExplicit: false, 0, null)
	{
	}

	public DerTaggedObject(bool isExplicit, int tagNo, Asn1Encodable obj)
		: base(isExplicit: false, 0, null)
	{
	}

	public DerTaggedObject(bool isExplicit, int tagClass, int tagNo, Asn1Encodable obj)
		: base(isExplicit: false, 0, null)
	{
	}

	internal DerTaggedObject(int explicitness, int tagClass, int tagNo, Asn1Encodable obj)
		: base(isExplicit: false, 0, null)
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

	internal sealed override DerEncoding GetEncodingDer()
	{
		return null;
	}

	internal sealed override DerEncoding GetEncodingDerImplicit(int tagClass, int tagNo)
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
