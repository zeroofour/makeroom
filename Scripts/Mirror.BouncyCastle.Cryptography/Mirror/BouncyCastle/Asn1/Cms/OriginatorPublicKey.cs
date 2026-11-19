using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cms;

public class OriginatorPublicKey : Asn1Encodable
{
	private readonly AlgorithmIdentifier m_algorithm;

	private readonly DerBitString m_publicKey;

	public AlgorithmIdentifier Algorithm => null;

	public DerBitString PublicKey => null;

	public static OriginatorPublicKey GetInstance(object obj)
	{
		return null;
	}

	public static OriginatorPublicKey GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	public OriginatorPublicKey(AlgorithmIdentifier algorithm, byte[] publicKey)
	{
	}

	public OriginatorPublicKey(AlgorithmIdentifier algorithm, DerBitString publicKey)
	{
	}

	private OriginatorPublicKey(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
