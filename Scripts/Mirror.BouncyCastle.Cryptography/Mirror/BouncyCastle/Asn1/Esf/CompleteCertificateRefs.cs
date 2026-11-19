using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class CompleteCertificateRefs : Asn1Encodable
{
	private readonly Asn1Sequence m_otherCertIDs;

	public static CompleteCertificateRefs GetInstance(object obj)
	{
		return null;
	}

	public static CompleteCertificateRefs GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CompleteCertificateRefs(Asn1Sequence seq)
	{
	}

	public CompleteCertificateRefs(params OtherCertID[] otherCertIDs)
	{
	}

	public CompleteCertificateRefs(IEnumerable<OtherCertID> otherCertIDs)
	{
	}

	public OtherCertID[] GetOtherCertIDs()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
