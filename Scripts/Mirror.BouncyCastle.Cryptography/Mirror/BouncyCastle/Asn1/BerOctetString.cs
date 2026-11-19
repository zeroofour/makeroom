using System;

namespace Mirror.BouncyCastle.Asn1;

public class BerOctetString : DerOctetString
{
	private readonly Asn1OctetString[] elements;

	public static BerOctetString FromSequence(Asn1Sequence seq)
	{
		return null;
	}

	internal static byte[] FlattenOctetStrings(Asn1OctetString[] octetStrings)
	{
		return null;
	}

	public BerOctetString(byte[] contents)
		: base((byte[])null)
	{
	}

	public BerOctetString(Asn1OctetString[] elements)
		: base((byte[])null)
	{
	}

	[Obsolete("Use version without segmentLimit (which is ignored anyway)")]
	public BerOctetString(byte[] contents, int segmentLimit)
		: base((byte[])null)
	{
	}

	[Obsolete("Use version without segmentLimit (which is ignored anyway)")]
	public BerOctetString(Asn1OctetString[] elements, int segmentLimit)
		: base((byte[])null)
	{
	}

	private BerOctetString(byte[] contents, Asn1OctetString[] elements)
		: base((byte[])null)
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
