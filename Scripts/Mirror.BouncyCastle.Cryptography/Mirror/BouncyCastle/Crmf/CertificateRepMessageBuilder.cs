using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1.Cmp;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Crmf;

public class CertificateRepMessageBuilder
{
	private readonly List<CertResponse> m_responses;

	private readonly CmpCertificate[] m_caCerts;

	public CertificateRepMessageBuilder(params X509Certificate[] caCerts)
	{
	}

	public virtual CertificateRepMessageBuilder AddCertificateResponse(CertificateResponse response)
	{
		return null;
	}

	public virtual CertificateRepMessage Build()
	{
		return null;
	}
}
