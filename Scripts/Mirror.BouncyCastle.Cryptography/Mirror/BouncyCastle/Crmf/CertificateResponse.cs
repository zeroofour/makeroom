using Mirror.BouncyCastle.Asn1.Cmp;
using Mirror.BouncyCastle.Cms;

namespace Mirror.BouncyCastle.Crmf;

public class CertificateResponse
{
	private readonly CertResponse m_certResponse;

	public virtual bool HasEncryptedCertificate => false;

	public CertificateResponse(CertResponse certResponse)
	{
	}

	public virtual CmsEnvelopedData GetEncryptedCertificate()
	{
		return null;
	}

	public virtual CmpCertificate GetCertificate()
	{
		return null;
	}

	public virtual CertResponse ToAsn1Structure()
	{
		return null;
	}
}
