namespace Mirror.BouncyCastle.Asn1.Tsp;

public class EncryptionInfo : Asn1Encodable
{
	private readonly DerObjectIdentifier m_encryptionInfoType;

	private readonly Asn1Encodable m_encryptionInfoValue;

	public virtual DerObjectIdentifier EncryptionInfoType => null;

	public virtual Asn1Encodable EncryptionInfoValue => null;

	public static EncryptionInfo GetInstance(object obj)
	{
		return null;
	}

	public static EncryptionInfo GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private EncryptionInfo(Asn1Sequence sequence)
	{
	}

	public EncryptionInfo(DerObjectIdentifier encryptionInfoType, Asn1Encodable encryptionInfoValue)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
