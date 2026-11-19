namespace Mirror.BouncyCastle.Asn1;

public class DLExternal : DerExternal
{
	public DLExternal(Asn1EncodableVector vector)
		: base((Asn1EncodableVector)null)
	{
	}

	public DLExternal(Asn1Sequence sequence)
		: base((Asn1EncodableVector)null)
	{
	}

	public DLExternal(DerObjectIdentifier directReference, DerInteger indirectReference, Asn1ObjectDescriptor dataValueDescriptor, Asn1TaggedObject externalData)
		: base((Asn1EncodableVector)null)
	{
	}

	public DLExternal(DerObjectIdentifier directReference, DerInteger indirectReference, Asn1ObjectDescriptor dataValueDescriptor, int encoding, Asn1Object externalData)
		: base((Asn1EncodableVector)null)
	{
	}

	internal override Asn1Sequence BuildSequence()
	{
		return null;
	}

	internal override IAsn1Encoding GetEncodingImplicit(int encoding, int tagClass, int tagNo)
	{
		return null;
	}
}
