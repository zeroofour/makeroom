using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Smime;

public class SmimeEncryptionKeyPreferenceAttribute : AttributeX509
{
	public SmimeEncryptionKeyPreferenceAttribute(IssuerAndSerialNumber issAndSer)
		: base(null, null)
	{
	}

	public SmimeEncryptionKeyPreferenceAttribute(RecipientKeyIdentifier rKeyID)
		: base(null, null)
	{
	}

	public SmimeEncryptionKeyPreferenceAttribute(Asn1OctetString sKeyID)
		: base(null, null)
	{
	}
}
