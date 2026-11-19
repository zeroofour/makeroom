using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class CrlSource : Asn1Encodable, IAsn1Choice
{
	private readonly DistributionPointName m_dpn;

	private readonly GeneralNames m_issuer;

	public virtual DistributionPointName Dpn => null;

	public virtual GeneralNames Issuer => null;

	public static CrlSource GetInstance(object obj)
	{
		return null;
	}

	public static CrlSource GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CrlSource(Asn1TaggedObject taggedObject)
	{
	}

	public CrlSource(DistributionPointName dpn, GeneralNames issuer)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
