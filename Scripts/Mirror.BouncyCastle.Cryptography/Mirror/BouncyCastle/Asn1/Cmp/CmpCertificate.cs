using System;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class CmpCertificate : Asn1Encodable, IAsn1Choice
{
	private readonly X509CertificateStructure m_x509v3PKCert;

	private readonly int m_otherTag;

	private readonly Asn1Encodable m_otherObject;

	public virtual bool IsX509v3PKCert => false;

	public virtual X509CertificateStructure X509v3PKCert => null;

	public virtual int OtherCertTag => 0;

	public virtual Asn1Encodable OtherCert => null;

	public static CmpCertificate GetInstance(object obj)
	{
		return null;
	}

	public static CmpCertificate GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	[Obsolete("Use 'GetInstance' from tagged object instead")]
	public CmpCertificate(int type, Asn1Encodable otherCert)
	{
	}

	internal CmpCertificate(Asn1TaggedObject taggedObject)
	{
	}

	internal CmpCertificate(CmpCertificate other)
	{
	}

	public CmpCertificate(X509CertificateStructure x509v3PKCert)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
