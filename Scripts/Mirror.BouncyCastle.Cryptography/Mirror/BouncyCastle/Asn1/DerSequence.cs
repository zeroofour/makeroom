namespace Mirror.BouncyCastle.Asn1;

public class DerSequence : Asn1Sequence
{
	public static readonly DerSequence Empty;

	public static DerSequence Concatenate(params Asn1Sequence[] sequences)
	{
		return null;
	}

	internal static DerSequence FromElements(Asn1Encodable[] elements)
	{
		return null;
	}

	public static DerSequence FromSequence(Asn1Sequence sequence)
	{
		return null;
	}

	public static DerSequence FromVector(Asn1EncodableVector elementVector)
	{
		return null;
	}

	public DerSequence()
	{
	}

	public DerSequence(Asn1Encodable element)
	{
	}

	public DerSequence(Asn1Encodable element1, Asn1Encodable element2)
	{
	}

	public DerSequence(params Asn1Encodable[] elements)
	{
	}

	public DerSequence(Asn1EncodableVector elementVector)
	{
	}

	internal DerSequence(Asn1Encodable[] elements, bool clone)
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

	internal override DerBitString ToAsn1BitString()
	{
		return null;
	}

	internal override DerExternal ToAsn1External()
	{
		return null;
	}

	internal override Asn1OctetString ToAsn1OctetString()
	{
		return null;
	}

	internal override Asn1Set ToAsn1Set()
	{
		return null;
	}

	internal static int GetEncodingLength(int contentsLength)
	{
		return 0;
	}
}
