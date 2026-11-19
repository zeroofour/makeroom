namespace Mirror.BouncyCastle.Asn1;

public class BerSequence : DLSequence
{
	public new static readonly BerSequence Empty;

	public new static BerSequence Concatenate(params Asn1Sequence[] sequences)
	{
		return null;
	}

	internal new static BerSequence FromElements(Asn1Encodable[] elements)
	{
		return null;
	}

	public new static BerSequence FromSequence(Asn1Sequence sequence)
	{
		return null;
	}

	public new static BerSequence FromVector(Asn1EncodableVector elementVector)
	{
		return null;
	}

	public BerSequence()
	{
	}

	public BerSequence(Asn1Encodable element)
	{
	}

	public BerSequence(Asn1Encodable element1, Asn1Encodable element2)
	{
	}

	public BerSequence(params Asn1Encodable[] elements)
	{
	}

	public BerSequence(Asn1EncodableVector elementVector)
	{
	}

	internal BerSequence(Asn1Encodable[] elements, bool clone)
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
}
