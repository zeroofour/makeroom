using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class OtherHashAlgAndValue : Asn1Encodable
{
	private readonly AlgorithmIdentifier m_hashAlgorithm;

	private readonly Asn1OctetString m_hashValue;

	public AlgorithmIdentifier HashAlgorithm => null;

	public static OtherHashAlgAndValue GetInstance(object obj)
	{
		return null;
	}

	public static OtherHashAlgAndValue GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private OtherHashAlgAndValue(Asn1Sequence seq)
	{
	}

	public OtherHashAlgAndValue(AlgorithmIdentifier hashAlgorithm, byte[] hashValue)
	{
	}

	public OtherHashAlgAndValue(AlgorithmIdentifier hashAlgorithm, Asn1OctetString hashValue)
	{
	}

	public byte[] GetHashValue()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
