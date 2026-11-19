using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class OtherSigningCertificate : Asn1Encodable
{
	private readonly Asn1Sequence m_certs;

	private readonly Asn1Sequence m_policies;

	public static OtherSigningCertificate GetInstance(object obj)
	{
		return null;
	}

	public static OtherSigningCertificate GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private OtherSigningCertificate(Asn1Sequence seq)
	{
	}

	public OtherSigningCertificate(params OtherCertID[] certs)
	{
	}

	public OtherSigningCertificate(OtherCertID[] certs, params PolicyInformation[] policies)
	{
	}

	public OtherSigningCertificate(IEnumerable<OtherCertID> certs)
	{
	}

	public OtherSigningCertificate(IEnumerable<OtherCertID> certs, IEnumerable<PolicyInformation> policies)
	{
	}

	public OtherCertID[] GetCerts()
	{
		return null;
	}

	public PolicyInformation[] GetPolicies()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
