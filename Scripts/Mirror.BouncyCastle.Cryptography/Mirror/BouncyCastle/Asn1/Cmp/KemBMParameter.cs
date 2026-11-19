using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class KemBMParameter : Asn1Encodable
{
	private readonly AlgorithmIdentifier m_kdf;

	private readonly DerInteger m_len;

	private readonly AlgorithmIdentifier m_mac;

	public virtual AlgorithmIdentifier Kdf => null;

	public virtual DerInteger Len => null;

	public virtual AlgorithmIdentifier Mac => null;

	public static KemBMParameter GetInstance(object obj)
	{
		return null;
	}

	public static KemBMParameter GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private KemBMParameter(Asn1Sequence seq)
	{
	}

	public KemBMParameter(AlgorithmIdentifier kdf, DerInteger len, AlgorithmIdentifier mac)
	{
	}

	public KemBMParameter(AlgorithmIdentifier kdf, long len, AlgorithmIdentifier mac)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
