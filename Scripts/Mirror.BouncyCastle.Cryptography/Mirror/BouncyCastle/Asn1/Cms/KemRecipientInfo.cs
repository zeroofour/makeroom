using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cms;

public sealed class KemRecipientInfo : Asn1Encodable
{
	private static readonly DerInteger V1;

	private readonly DerInteger m_cmsVersion;

	private readonly RecipientIdentifier m_rid;

	private readonly AlgorithmIdentifier m_kem;

	private readonly Asn1OctetString m_kemct;

	private readonly AlgorithmIdentifier m_kdf;

	private readonly DerInteger m_kekLength;

	private readonly Asn1OctetString m_ukm;

	private readonly AlgorithmIdentifier m_wrap;

	private readonly Asn1OctetString m_encryptedKey;

	public RecipientIdentifier RecipientIdentifier => null;

	public AlgorithmIdentifier Kem => null;

	public Asn1OctetString Kemct => null;

	public AlgorithmIdentifier Kdf => null;

	public AlgorithmIdentifier Wrap => null;

	public Asn1OctetString Ukm => null;

	public Asn1OctetString EncryptedKey => null;

	public static KemRecipientInfo GetInstance(object obj)
	{
		return null;
	}

	public static KemRecipientInfo GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public KemRecipientInfo(RecipientIdentifier rid, AlgorithmIdentifier kem, Asn1OctetString kemct, AlgorithmIdentifier kdf, DerInteger kekLength, Asn1OctetString ukm, AlgorithmIdentifier wrap, Asn1OctetString encryptedKey)
	{
	}

	private KemRecipientInfo(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
