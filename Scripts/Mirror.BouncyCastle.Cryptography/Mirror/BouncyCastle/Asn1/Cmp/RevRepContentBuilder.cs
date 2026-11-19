using Mirror.BouncyCastle.Asn1.Crmf;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class RevRepContentBuilder
{
	private readonly Asn1EncodableVector m_status;

	private readonly Asn1EncodableVector m_revCerts;

	private readonly Asn1EncodableVector m_crls;

	public virtual RevRepContentBuilder Add(PkiStatusInfo status)
	{
		return null;
	}

	public virtual RevRepContentBuilder Add(PkiStatusInfo status, CertId certId)
	{
		return null;
	}

	public virtual RevRepContentBuilder AddCrl(CertificateList crl)
	{
		return null;
	}

	public virtual RevRepContent Build()
	{
		return null;
	}
}
