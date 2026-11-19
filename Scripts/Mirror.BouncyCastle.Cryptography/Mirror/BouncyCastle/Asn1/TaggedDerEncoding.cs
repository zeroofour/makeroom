namespace Mirror.BouncyCastle.Asn1;

internal class TaggedDerEncoding : DerEncoding
{
	private readonly DerEncoding m_contentsElement;

	private readonly int m_contentsLength;

	internal TaggedDerEncoding(int tagClass, int tagNo, DerEncoding contentsElement)
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
