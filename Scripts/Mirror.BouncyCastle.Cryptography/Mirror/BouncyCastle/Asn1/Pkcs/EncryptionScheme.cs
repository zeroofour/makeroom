using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Pkcs;

public class EncryptionScheme : AlgorithmIdentifier
{
	public Asn1Object Asn1Object => null;

	public new static EncryptionScheme GetInstance(object obj)
	{
		return null;
	}

	public new static EncryptionScheme GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public EncryptionScheme(DerObjectIdentifier objectID)
		: base((DerObjectIdentifier)null)
	{
	}

	public EncryptionScheme(DerObjectIdentifier objectID, Asn1Encodable parameters)
		: base((DerObjectIdentifier)null)
	{
	}

	internal EncryptionScheme(Asn1Sequence seq)
		: base((DerObjectIdentifier)null)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
