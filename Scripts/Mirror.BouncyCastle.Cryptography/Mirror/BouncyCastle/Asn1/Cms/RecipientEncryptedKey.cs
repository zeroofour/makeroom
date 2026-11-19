namespace Mirror.BouncyCastle.Asn1.Cms;

public class RecipientEncryptedKey : Asn1Encodable
{
	private readonly KeyAgreeRecipientIdentifier identifier;

	private readonly Asn1OctetString encryptedKey;

	public KeyAgreeRecipientIdentifier Identifier => null;

	public Asn1OctetString EncryptedKey => null;

	public static RecipientEncryptedKey GetInstance(object obj)
	{
		return null;
	}

	public static RecipientEncryptedKey GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		return null;
	}

	private RecipientEncryptedKey(Asn1Sequence seq)
	{
	}

	public RecipientEncryptedKey(KeyAgreeRecipientIdentifier id, Asn1OctetString encryptedKey)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
