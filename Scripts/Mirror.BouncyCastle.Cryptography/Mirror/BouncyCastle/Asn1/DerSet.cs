namespace Mirror.BouncyCastle.Asn1;

public class DerSet : Asn1Set
{
	public static readonly DerSet Empty;

	public static DerSet FromVector(Asn1EncodableVector elementVector)
	{
		return null;
	}

	public DerSet()
	{
	}

	public DerSet(Asn1Encodable element)
	{
	}

	public DerSet(params Asn1Encodable[] elements)
	{
	}

	internal DerSet(Asn1Encodable[] elements, bool doSort)
	{
	}

	public DerSet(Asn1EncodableVector elementVector)
	{
	}

	internal DerSet(Asn1EncodableVector elementVector, bool doSort)
	{
	}

	internal DerSet(bool isSorted, Asn1Encodable[] elements)
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

	private DerEncoding[] GetSortedDerEncodings()
	{
		return null;
	}

	private static DerEncoding[] CreateSortedDerEncodings(Asn1Encodable[] elements)
	{
		return null;
	}
}
