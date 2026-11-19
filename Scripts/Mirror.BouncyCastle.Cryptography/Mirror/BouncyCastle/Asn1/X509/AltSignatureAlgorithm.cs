namespace Mirror.BouncyCastle.Asn1.X509;

public class AltSignatureAlgorithm : Asn1Encodable
{
	private readonly AlgorithmIdentifier m_algorithm;

	public AlgorithmIdentifier Algorithm => null;

	public static AltSignatureAlgorithm GetInstance(object obj)
	{
		return null;
	}

	public static AltSignatureAlgorithm GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public static AltSignatureAlgorithm FromExtensions(X509Extensions extensions)
	{
		return null;
	}

	public AltSignatureAlgorithm(AlgorithmIdentifier algorithm)
	{
	}

	public AltSignatureAlgorithm(DerObjectIdentifier algorithm)
	{
	}

	public AltSignatureAlgorithm(DerObjectIdentifier algorithm, Asn1Encodable parameters)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
