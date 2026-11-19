using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class CrlStatus : Asn1Encodable
{
	private readonly CrlSource m_source;

	private readonly Time m_thisUpdate;

	public virtual CrlSource Source => null;

	public virtual Time ThisUpdate => null;

	public static CrlStatus GetInstance(object obj)
	{
		return null;
	}

	public static CrlStatus GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CrlStatus(Asn1Sequence sequence)
	{
	}

	public CrlStatus(CrlSource source, Time thisUpdate)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
