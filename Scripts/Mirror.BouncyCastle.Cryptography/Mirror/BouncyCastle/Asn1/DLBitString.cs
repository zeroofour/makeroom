namespace Mirror.BouncyCastle.Asn1;

public class DLBitString : DerBitString
{
	public DLBitString(byte data, int padBits)
		: base(0, 0)
	{
	}

	public DLBitString(byte[] data)
		: base(0, 0)
	{
	}

	public DLBitString(byte[] data, int padBits)
		: base(0, 0)
	{
	}

	public DLBitString(int namedBits)
		: base(0, 0)
	{
	}

	public DLBitString(Asn1Encodable obj)
		: base(0, 0)
	{
	}

	internal DLBitString(byte[] contents, bool check)
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
