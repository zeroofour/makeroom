using Mirror.BouncyCastle.Asn1.Crmf;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class CertOrEncCert : Asn1Encodable, IAsn1Choice
{
	private readonly CmpCertificate m_certificate;

	private readonly EncryptedKey m_encryptedCert;

	public virtual CmpCertificate Certificate => null;

	public virtual EncryptedKey EncryptedCert => null;

	public virtual bool HasEncryptedCertificate => false;

	public static CertOrEncCert GetInstance(object obj)
	{
		return null;
	}

	public static CertOrEncCert GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CertOrEncCert(Asn1TaggedObject taggedObject)
	{
	}

	public CertOrEncCert(CmpCertificate certificate)
	{
	}

	public CertOrEncCert(EncryptedValue encryptedValue)
	{
	}

	public CertOrEncCert(EncryptedKey encryptedKey)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
