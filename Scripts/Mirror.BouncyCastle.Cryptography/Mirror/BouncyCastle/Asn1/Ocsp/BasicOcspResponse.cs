using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Ocsp;

public class BasicOcspResponse : Asn1Encodable
{
	private readonly ResponseData m_tbsResponseData;

	private readonly AlgorithmIdentifier m_signatureAlgorithm;

	private readonly DerBitString m_signature;

	private readonly Asn1Sequence m_certs;

	public ResponseData TbsResponseData => null;

	public AlgorithmIdentifier SignatureAlgorithm => null;

	public DerBitString Signature => null;

	public Asn1Sequence Certs => null;

	public static BasicOcspResponse GetInstance(object obj)
	{
		return null;
	}

	public static BasicOcspResponse GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	public BasicOcspResponse(ResponseData tbsResponseData, AlgorithmIdentifier signatureAlgorithm, DerBitString signature, Asn1Sequence certs)
	{
	}

	private BasicOcspResponse(Asn1Sequence seq)
	{
	}

	public byte[] GetSignatureOctets()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
