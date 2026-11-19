namespace Mirror.BouncyCastle.Asn1.X509;

public class SubjectAltPublicKeyInfo : Asn1Encodable
{
	private readonly AlgorithmIdentifier m_algorithm;

	private readonly DerBitString m_subjectAltPublicKey;

	public AlgorithmIdentifier Algorithm => null;

	public DerBitString SubjectAltPublicKey => null;

	public static SubjectAltPublicKeyInfo GetInstance(object obj)
	{
		return null;
	}

	public static SubjectAltPublicKeyInfo GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public static SubjectAltPublicKeyInfo FromExtensions(X509Extensions extensions)
	{
		return null;
	}

	private SubjectAltPublicKeyInfo(Asn1Sequence seq)
	{
	}

	public SubjectAltPublicKeyInfo(AlgorithmIdentifier algorithm, DerBitString subjectAltPublicKey)
	{
	}

	public SubjectAltPublicKeyInfo(SubjectPublicKeyInfo subjectPublicKeyInfo)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
