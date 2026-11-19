using System;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class CertAnnContent : CmpCertificate
{
	public new static CertAnnContent GetInstance(object obj)
	{
		return null;
	}

	public new static CertAnnContent GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	[Obsolete("Use 'GetInstance' from tagged object instead")]
	public CertAnnContent(int type, Asn1Object otherCert)
		: base(0, null)
	{
	}

	internal CertAnnContent(Asn1TaggedObject taggedObject)
		: base(0, null)
	{
	}

	internal CertAnnContent(CmpCertificate other)
		: base(0, null)
	{
	}

	public CertAnnContent(X509CertificateStructure x509v3PKCert)
		: base(0, null)
	{
	}
}
