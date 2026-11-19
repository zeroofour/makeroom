using System;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cms;

public class KekRecipientInfo : Asn1Encodable
{
	private DerInteger version;

	private KekIdentifier kekID;

	private AlgorithmIdentifier keyEncryptionAlgorithm;

	private Asn1OctetString encryptedKey;

	public DerInteger Version => null;

	public KekIdentifier KekID => null;

	public AlgorithmIdentifier KeyEncryptionAlgorithm => null;

	public Asn1OctetString EncryptedKey => null;

	public static KekRecipientInfo GetInstance(object obj)
	{
		return null;
	}

	public static KekRecipientInfo GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	public KekRecipientInfo(KekIdentifier kekID, AlgorithmIdentifier keyEncryptionAlgorithm, Asn1OctetString encryptedKey)
	{
	}

	[Obsolete("Use 'GetInstance' instead")]
	public KekRecipientInfo(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
