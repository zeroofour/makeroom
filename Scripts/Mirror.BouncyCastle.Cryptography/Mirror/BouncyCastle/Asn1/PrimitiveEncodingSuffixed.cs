namespace Mirror.BouncyCastle.Asn1;

internal class PrimitiveEncodingSuffixed : IAsn1Encoding
{
	private readonly int m_tagClass;

	private readonly int m_tagNo;

	private readonly byte[] m_contentsOctets;

	private readonly byte m_contentsSuffix;

	internal PrimitiveEncodingSuffixed(int tagClass, int tagNo, byte[] contentsOctets, byte contentsSuffix)
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
