using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cmp;
using Mirror.BouncyCastle.Cms;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Crmf;

public class CertificateResponseBuilder
{
	private readonly DerInteger m_certReqID;

	private readonly PkiStatusInfo m_statusInfo;

	private CertifiedKeyPair m_certKeyPair;

	private Asn1OctetString m_rspInfo;

	public CertificateResponseBuilder(DerInteger certReqID, PkiStatusInfo statusInfo)
	{
	}

	public virtual CertificateResponseBuilder WithCertificate(X509Certificate certificate)
	{
		return null;
	}

	public virtual CertificateResponseBuilder WithCertificate(CmpCertificate cmpCertificate)
	{
		return null;
	}

	public virtual CertificateResponseBuilder WithCertificate(CmsEnvelopedData encryptedCertificate)
	{
		return null;
	}

	public virtual CertificateResponseBuilder WithResponseInfo(byte[] responseInfo)
	{
		return null;
	}

	public virtual CertificateResponse Build()
	{
		return null;
	}
}
