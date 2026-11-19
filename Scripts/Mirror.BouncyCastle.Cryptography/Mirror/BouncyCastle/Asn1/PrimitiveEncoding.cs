namespace Mirror.BouncyCastle.Asn1;

internal class PrimitiveEncoding : IAsn1Encoding
{
	private readonly int m_tagClass;

	private readonly int m_tagNo;

	private readonly byte[] m_contentsOctets;

	internal PrimitiveEncoding(int tagClass, int tagNo, byte[] contentsOctets)
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
