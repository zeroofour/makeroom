using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class OcspListID : Asn1Encodable
{
	private readonly Asn1Sequence m_ocspResponses;

	public static OcspListID GetInstance(object obj)
	{
		return null;
	}

	public static OcspListID GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private OcspListID(Asn1Sequence seq)
	{
	}

	public OcspListID(params OcspResponsesID[] ocspResponses)
	{
	}

	public OcspListID(IEnumerable<OcspResponsesID> ocspResponses)
	{
	}

	public OcspResponsesID[] GetOcspResponses()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
