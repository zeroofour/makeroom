using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class CertificateValues : Asn1Encodable
{
	private readonly Asn1Sequence m_certificates;

	public static CertificateValues GetInstance(object obj)
	{
		return null;
	}

	public static CertificateValues GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CertificateValues(Asn1Sequence seq)
	{
	}

	public CertificateValues(params X509CertificateStructure[] certificates)
	{
	}

	public CertificateValues(IEnumerable<X509CertificateStructure> certificates)
	{
	}

	public X509CertificateStructure[] GetCertificates()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
