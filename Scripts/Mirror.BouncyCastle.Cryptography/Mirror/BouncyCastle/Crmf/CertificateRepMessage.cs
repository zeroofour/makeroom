using Mirror.BouncyCastle.Asn1.Cmp;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Crmf;

public class CertificateRepMessage
{
	private readonly CertResponse[] m_resps;

	private readonly CmpCertificate[] m_caCerts;

	public static CertificateRepMessage FromPkiBody(PkiBody pkiBody)
	{
		return null;
	}

	public static bool IsCertificateRepMessage(int bodyType)
	{
		return false;
	}

	public CertificateRepMessage(CertRepMessage repMessage)
	{
	}

	public virtual CertificateResponse[] GetResponses()
	{
		return null;
	}

	public virtual X509Certificate[] GetX509Certificates()
	{
		return null;
	}

	public virtual bool IsOnlyX509PKCertificates()
	{
		return false;
	}

	public virtual CmpCertificate[] GetCmpCertificates()
	{
		return null;
	}

	public virtual CertRepMessage ToAsn1Structure()
	{
		return null;
	}
}
