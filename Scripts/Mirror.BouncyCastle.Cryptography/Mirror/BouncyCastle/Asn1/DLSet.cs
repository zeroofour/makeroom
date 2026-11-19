namespace Mirror.BouncyCastle.Asn1;

public class DLSet : DerSet
{
	public new static readonly DLSet Empty;

	public new static DLSet FromVector(Asn1EncodableVector elementVector)
	{
		return null;
	}

	public DLSet()
	{
	}

	public DLSet(Asn1Encodable element)
	{
	}

	public DLSet(params Asn1Encodable[] elements)
	{
	}

	public DLSet(Asn1EncodableVector elementVector)
	{
	}

	internal DLSet(bool isSorted, Asn1Encodable[] elements)
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
