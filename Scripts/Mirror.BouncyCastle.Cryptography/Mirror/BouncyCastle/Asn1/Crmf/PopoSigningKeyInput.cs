using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Crmf;

public class PopoSigningKeyInput : Asn1Encodable
{
	private readonly GeneralName m_sender;

	private readonly PKMacValue m_publicKeyMac;

	private readonly SubjectPublicKeyInfo m_publicKey;

	public virtual GeneralName Sender => null;

	public virtual PKMacValue PublicKeyMac => null;

	public virtual SubjectPublicKeyInfo PublicKey => null;

	public static PopoSigningKeyInput GetInstance(object obj)
	{
		return null;
	}

	public static PopoSigningKeyInput GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private PopoSigningKeyInput(Asn1Sequence seq)
	{
	}

	public PopoSigningKeyInput(GeneralName sender, SubjectPublicKeyInfo spki)
	{
	}

	public PopoSigningKeyInput(PKMacValue pkmac, SubjectPublicKeyInfo spki)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
