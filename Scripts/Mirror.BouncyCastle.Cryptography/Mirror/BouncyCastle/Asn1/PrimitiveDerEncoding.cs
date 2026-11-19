namespace Mirror.BouncyCastle.Asn1;

internal class PrimitiveDerEncoding : DerEncoding
{
	internal readonly byte[] m_contentsOctets;

	internal PrimitiveDerEncoding(int tagClass, int tagNo, byte[] contentsOctets)
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
}
