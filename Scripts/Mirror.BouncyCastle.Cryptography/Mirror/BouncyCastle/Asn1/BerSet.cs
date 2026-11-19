namespace Mirror.BouncyCastle.Asn1;

public class BerSet : DLSet
{
	public new static readonly BerSet Empty;

	public new static BerSet FromVector(Asn1EncodableVector elementVector)
	{
		return null;
	}

	public BerSet()
	{
	}

	public BerSet(Asn1Encodable element)
	{
	}

	public BerSet(params Asn1Encodable[] elements)
	{
	}

	public BerSet(Asn1EncodableVector elementVector)
	{
	}

	internal BerSet(bool isSorted, Asn1Encodable[] elements)
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
}
