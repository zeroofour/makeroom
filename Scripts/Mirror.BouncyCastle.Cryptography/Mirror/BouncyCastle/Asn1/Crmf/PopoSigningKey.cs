using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Crmf;

public class PopoSigningKey : Asn1Encodable
{
	private readonly PopoSigningKeyInput m_poposkInput;

	private readonly AlgorithmIdentifier m_algorithmIdentifier;

	private readonly DerBitString m_signature;

	public virtual PopoSigningKeyInput PoposkInput => null;

	public virtual AlgorithmIdentifier AlgorithmIdentifier => null;

	public virtual DerBitString Signature => null;

	public static PopoSigningKey GetInstance(object obj)
	{
		return null;
	}

	public static PopoSigningKey GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		return null;
	}

	private PopoSigningKey(Asn1Sequence seq)
	{
	}

	public PopoSigningKey(PopoSigningKeyInput poposkIn, AlgorithmIdentifier aid, DerBitString signature)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
