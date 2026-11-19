namespace Mirror.BouncyCastle.Asn1;

public class DerOctetString : Asn1OctetString
{
	public DerOctetString(byte[] contents)
		: base(null)
	{
	}

	public DerOctetString(IAsn1Convertible obj)
		: base(null)
	{
	}

	public DerOctetString(Asn1Encodable obj)
		: base(null)
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

	internal sealed override DerEncoding GetEncodingDer()
	{
		return null;
	}

	internal sealed override DerEncoding GetEncodingDerImplicit(int tagClass, int tagNo)
	{
		return null;
	}

	internal static void Encode(Asn1OutputStream asn1Out, byte[] buf, int off, int len)
	{
	}
}
