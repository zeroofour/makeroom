using Mirror.BouncyCastle.Asn1.Cmp;
using Mirror.BouncyCastle.Asn1.Crmf;

namespace Mirror.BouncyCastle.Crmf;

public class CertificateReqMessages
{
	private readonly CertReqMsg[] m_reqs;

	public static CertificateReqMessages FromPkiBody(PkiBody pkiBody)
	{
		return null;
	}

	public static bool IsCertificateRequestMessages(int bodyType)
	{
		return false;
	}

	public CertificateReqMessages(CertReqMessages certReqMessages)
	{
	}

	public virtual CertificateRequestMessage[] GetRequests()
	{
		return null;
	}

	public virtual CertReqMessages ToAsn1Structure()
	{
		return null;
	}
}
