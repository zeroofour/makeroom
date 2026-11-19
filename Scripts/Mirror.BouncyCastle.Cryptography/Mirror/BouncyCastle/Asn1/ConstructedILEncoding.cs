namespace Mirror.BouncyCastle.Asn1;

internal class ConstructedILEncoding : IAsn1Encoding
{
	private readonly int m_tagClass;

	private readonly int m_tagNo;

	private readonly IAsn1Encoding[] m_contentsElements;

	internal ConstructedILEncoding(int tagClass, int tagNo, IAsn1Encoding[] contentsElements)
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
