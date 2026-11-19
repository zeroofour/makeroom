using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class DhbmParameter : Asn1Encodable
{
	private readonly AlgorithmIdentifier m_owf;

	private readonly AlgorithmIdentifier m_mac;

	public virtual AlgorithmIdentifier Owf => null;

	public virtual AlgorithmIdentifier Mac => null;

	public static DhbmParameter GetInstance(object obj)
	{
		return null;
	}

	public static DhbmParameter GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private DhbmParameter(Asn1Sequence sequence)
	{
	}

	public DhbmParameter(AlgorithmIdentifier owf, AlgorithmIdentifier mac)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
