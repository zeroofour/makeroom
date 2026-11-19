using System;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cms;

public class KeyTransRecipientInfo : Asn1Encodable
{
	private DerInteger version;

	private RecipientIdentifier rid;

	private AlgorithmIdentifier keyEncryptionAlgorithm;

	private Asn1OctetString encryptedKey;

	public DerInteger Version => null;

	public RecipientIdentifier RecipientIdentifier => null;

	public AlgorithmIdentifier KeyEncryptionAlgorithm => null;

	public Asn1OctetString EncryptedKey => null;

	public static KeyTransRecipientInfo GetInstance(object obj)
	{
		return null;
	}

	public static KeyTransRecipientInfo GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public KeyTransRecipientInfo(RecipientIdentifier rid, AlgorithmIdentifier keyEncryptionAlgorithm, Asn1OctetString encryptedKey)
	{
	}

	[Obsolete("Use 'GetInstance' instead")]
	public KeyTransRecipientInfo(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
