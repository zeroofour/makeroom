using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Mozilla;

public class SignedPublicKeyAndChallenge : Asn1Encodable
{
	private readonly PublicKeyAndChallenge m_publicKeyAndChallenge;

	private readonly AlgorithmIdentifier m_signatureAlgorithm;

	private readonly DerBitString m_signature;

	public PublicKeyAndChallenge PublicKeyAndChallenge => null;

	public DerBitString Signature => null;

	public AlgorithmIdentifier SignatureAlgorithm => null;

	public static SignedPublicKeyAndChallenge GetInstance(object obj)
	{
		return null;
	}

	public static SignedPublicKeyAndChallenge GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public SignedPublicKeyAndChallenge(PublicKeyAndChallenge publicKeyAndChallenge, AlgorithmIdentifier signatureAlgorithm, DerBitString signature)
	{
	}

	private SignedPublicKeyAndChallenge(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
