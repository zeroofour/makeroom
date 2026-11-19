namespace Mirror.BouncyCastle.Asn1;

public class DLSequence : DerSequence
{
	public new static readonly DLSequence Empty;

	public new static DLSequence Concatenate(params Asn1Sequence[] sequences)
	{
		return null;
	}

	internal new static DLSequence FromElements(Asn1Encodable[] elements)
	{
		return null;
	}

	public new static DLSequence FromSequence(Asn1Sequence sequence)
	{
		return null;
	}

	public new static DLSequence FromVector(Asn1EncodableVector elementVector)
	{
		return null;
	}

	public DLSequence()
	{
	}

	public DLSequence(Asn1Encodable element)
	{
	}

	public DLSequence(Asn1Encodable element1, Asn1Encodable element2)
	{
	}

	public DLSequence(params Asn1Encodable[] elements)
	{
	}

	public DLSequence(Asn1EncodableVector elementVector)
	{
	}

	internal DLSequence(Asn1Encodable[] elements, bool clone)
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

	internal override Asn1Set ToAsn1Set()
	{
		return null;
	}
}
