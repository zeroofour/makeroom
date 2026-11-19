namespace Mirror.BouncyCastle.Asn1.Ocsp;

public class OcspResponse : Asn1Encodable
{
	private readonly OcspResponseStatus m_responseStatus;

	private readonly ResponseBytes m_responseBytes;

	public OcspResponseStatus ResponseStatus => null;

	public ResponseBytes ResponseBytes => null;

	public static OcspResponse GetInstance(object obj)
	{
		return null;
	}

	public static OcspResponse GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	public OcspResponse(OcspResponseStatus responseStatus, ResponseBytes responseBytes)
	{
	}

	private OcspResponse(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
