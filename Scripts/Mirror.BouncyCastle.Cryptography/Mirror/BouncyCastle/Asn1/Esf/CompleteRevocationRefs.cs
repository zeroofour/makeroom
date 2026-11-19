using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class CompleteRevocationRefs : Asn1Encodable
{
	private readonly Asn1Sequence m_crlOcspRefs;

	public static CompleteRevocationRefs GetInstance(object obj)
	{
		return null;
	}

	public static CompleteRevocationRefs GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CompleteRevocationRefs(Asn1Sequence seq)
	{
	}

	public CompleteRevocationRefs(params CrlOcspRef[] crlOcspRefs)
	{
	}

	public CompleteRevocationRefs(IEnumerable<CrlOcspRef> crlOcspRefs)
	{
	}

	public CrlOcspRef[] GetCrlOcspRefs()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
