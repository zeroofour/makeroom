using Mirror.BouncyCastle.Asn1.Cms;

namespace Mirror.BouncyCastle.Asn1.Tsp;

public class CryptoInfos : Asn1Encodable
{
	private readonly Asn1Sequence m_attributes;

	public static CryptoInfos GetInstance(object obj)
	{
		return null;
	}

	public static CryptoInfos GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CryptoInfos(Asn1Sequence attributes)
	{
	}

	public CryptoInfos(Attribute[] attrs)
	{
	}

	public virtual Attribute[] GetAttributes()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
