namespace Mirror.BouncyCastle.Asn1;

internal class PrimitiveDerEncodingSuffixed : DerEncoding
{
	private readonly byte[] m_contentsOctets;

	private readonly byte m_contentsSuffix;

	internal PrimitiveDerEncodingSuffixed(int tagClass, int tagNo, byte[] contentsOctets, byte contentsSuffix)
		: base(0, 0)
	{
	}

	protected internal override int CompareLengthAndContents(DerEncoding other)
	{
		return 0;
	}

	public override void Encode(Asn1OutputStream asn1Out)
	{
	}

	public override int GetLength()
	{
		return 0;
	}

	private static int CompareSuffixed(byte[] octetsA, byte suffixA, byte[] octetsB, byte suffixB)
	{
		return 0;
	}
}
