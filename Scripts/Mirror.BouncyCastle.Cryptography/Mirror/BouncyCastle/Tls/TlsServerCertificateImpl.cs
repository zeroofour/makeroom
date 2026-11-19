namespace Mirror.BouncyCastle.Tls;

internal sealed class TlsServerCertificateImpl : TlsServerCertificate
{
	private readonly Certificate m_certificate;

	private readonly CertificateStatus m_certificateStatus;

	public Certificate Certificate => null;

	public CertificateStatus CertificateStatus => null;

	internal TlsServerCertificateImpl(Certificate certificate, CertificateStatus certificateStatus)
	{
	}
}
