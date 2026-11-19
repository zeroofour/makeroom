using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1.Crmf;

namespace Mirror.BouncyCastle.Crmf;

public class CertificateReqMessagesBuilder
{
	private readonly List<CertReqMsg> m_requests;

	public virtual void AddRequest(CertificateRequestMessage request)
	{
	}

	public virtual CertificateReqMessages Build()
	{
		return null;
	}
}
