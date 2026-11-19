using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class CrlListID : Asn1Encodable
{
	private readonly Asn1Sequence m_crls;

	public static CrlListID GetInstance(object obj)
	{
		return null;
	}

	public static CrlListID GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CrlListID(Asn1Sequence seq)
	{
	}

	public CrlListID(params CrlValidatedID[] crls)
	{
	}

	public CrlListID(IEnumerable<CrlValidatedID> crls)
	{
	}

	public CrlValidatedID[] GetCrls()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
