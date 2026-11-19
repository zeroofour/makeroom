using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class KemCiphertextInfo : Asn1Encodable
{
	private readonly AlgorithmIdentifier m_kem;

	private readonly Asn1OctetString m_ct;

	public virtual AlgorithmIdentifier Kem => null;

	public virtual Asn1OctetString Ct => null;

	public static KemCiphertextInfo GetInstance(object obj)
	{
		return null;
	}

	public static KemCiphertextInfo GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private KemCiphertextInfo(Asn1Sequence seq)
	{
	}

	public KemCiphertextInfo(AlgorithmIdentifier kem, Asn1OctetString ct)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
