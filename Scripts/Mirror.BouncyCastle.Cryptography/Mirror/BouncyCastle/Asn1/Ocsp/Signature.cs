using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Ocsp;

public class Signature : Asn1Encodable
{
	private readonly AlgorithmIdentifier m_signatureAlgorithm;

	private readonly DerBitString m_signatureValue;

	private readonly Asn1Sequence m_certs;

	public AlgorithmIdentifier SignatureAlgorithm => null;

	public DerBitString SignatureValue => null;

	public Asn1Sequence Certs => null;

	public static Signature GetInstance(object obj)
	{
		return null;
	}

	public static Signature GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	public Signature(AlgorithmIdentifier signatureAlgorithm, DerBitString signatureValue)
	{
	}

	public Signature(AlgorithmIdentifier signatureAlgorithm, DerBitString signatureValue, Asn1Sequence certs)
	{
	}

	private Signature(Asn1Sequence seq)
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
