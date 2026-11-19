using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class OtherHash : Asn1Encodable, IAsn1Choice
{
	private readonly Asn1OctetString m_sha1Hash;

	private readonly OtherHashAlgAndValue m_otherHash;

	public AlgorithmIdentifier HashAlgorithm => null;

	public static OtherHash GetInstance(object obj)
	{
		return null;
	}

	public static OtherHash GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public OtherHash(byte[] sha1Hash)
	{
	}

	public OtherHash(Asn1OctetString sha1Hash)
	{
	}

	public OtherHash(OtherHashAlgAndValue otherHash)
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
