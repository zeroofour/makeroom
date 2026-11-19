using Mirror.BouncyCastle.Asn1.Crmf;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class CertifiedKeyPair : Asn1Encodable
{
	private readonly CertOrEncCert m_certOrEncCert;

	private readonly EncryptedKey m_privateKey;

	private readonly PkiPublicationInfo m_publicationInfo;

	public virtual CertOrEncCert CertOrEncCert => null;

	public virtual EncryptedKey PrivateKey => null;

	public virtual PkiPublicationInfo PublicationInfo => null;

	public static CertifiedKeyPair GetInstance(object obj)
	{
		return null;
	}

	public static CertifiedKeyPair GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CertifiedKeyPair(Asn1Sequence seq)
	{
	}

	public CertifiedKeyPair(CertOrEncCert certOrEncCert)
	{
	}

	public CertifiedKeyPair(CertOrEncCert certOrEncCert, EncryptedValue privateKey, PkiPublicationInfo publicationInfo)
	{
	}

	public CertifiedKeyPair(CertOrEncCert certOrEncCert, EncryptedKey privateKey, PkiPublicationInfo publicationInfo)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
