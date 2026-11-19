namespace Mirror.BouncyCastle.Asn1;

internal class TaggedILEncoding : IAsn1Encoding
{
	private readonly int m_tagClass;

	private readonly int m_tagNo;

	private readonly IAsn1Encoding m_contentsElement;

	internal TaggedILEncoding(int tagClass, int tagNo, IAsn1Encoding contentsElement)
	{
	}

	void IAsn1Encoding.Encode(Asn1OutputStream asn1Out)
	{
	}

	int IAsn1Encoding.GetLength()
	{
		return 0;
	}
}
