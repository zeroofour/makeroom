namespace Mirror.BouncyCastle.Asn1;

internal class ConstructedDerEncoding : DerEncoding
{
	private readonly DerEncoding[] m_contentsElements;

	private readonly int m_contentsLength;

	internal ConstructedDerEncoding(int tagClass, int tagNo, DerEncoding[] contentsElements)
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
