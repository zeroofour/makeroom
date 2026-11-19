using System;

namespace Mirror.BouncyCastle.Asn1;

public class BerBitString : DLBitString
{
	private readonly DerBitString[] elements;

	public static BerBitString FromSequence(Asn1Sequence seq)
	{
		return null;
	}

	internal static byte[] FlattenBitStrings(DerBitString[] bitStrings)
	{
		return null;
	}

	public BerBitString(byte data, int padBits)
		: base(0, 0)
	{
	}

	public BerBitString(byte[] data)
		: base(0, 0)
	{
	}

	public BerBitString(byte[] data, int padBits)
		: base(0, 0)
	{
	}

	[Obsolete("Use version without segmentLimit (which is ignored anyway)")]
	public BerBitString(byte[] data, int padBits, int segmentLimit)
		: base(0, 0)
	{
	}

	public BerBitString(int namedBits)
		: base(0, 0)
	{
	}

	public BerBitString(Asn1Encodable obj)
		: base(0, 0)
	{
	}

	public BerBitString(DerBitString[] elements)
		: base(0, 0)
	{
	}

	[Obsolete("Use version without segmentLimit (which is ignored anyway)")]
	public BerBitString(DerBitString[] elements, int segmentLimit)
		: base(0, 0)
	{
	}

	internal BerBitString(byte[] contents, bool check)
		: base(0, 0)
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
