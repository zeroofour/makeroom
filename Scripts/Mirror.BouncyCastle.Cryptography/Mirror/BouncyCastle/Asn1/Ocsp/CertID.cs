using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Ocsp;

public class CertID : Asn1Encodable
{
	private readonly AlgorithmIdentifier m_hashAlgorithm;

	private readonly Asn1OctetString m_issuerNameHash;

	private readonly Asn1OctetString m_issuerKeyHash;

	private readonly DerInteger m_serialNumber;

	public AlgorithmIdentifier HashAlgorithm => null;

	public Asn1OctetString IssuerNameHash => null;

	public Asn1OctetString IssuerKeyHash => null;

	public DerInteger SerialNumber => null;

	public static CertID GetInstance(object obj)
	{
		return null;
	}

	public static CertID GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	public CertID(AlgorithmIdentifier hashAlgorithm, Asn1OctetString issuerNameHash, Asn1OctetString issuerKeyHash, DerInteger serialNumber)
	{
	}

	private CertID(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
