using System;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class OobCert : CmpCertificate
{
	public new static OobCert GetInstance(object obj)
	{
		return null;
	}

	public new static OobCert GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	[Obsolete("Use constructor from Asn1TaggedObject instead")]
	public OobCert(int type, Asn1Encodable otherCert)
		: base(0, null)
	{
	}

	internal OobCert(Asn1TaggedObject taggedObject)
		: base(0, null)
	{
	}

	internal OobCert(CmpCertificate other)
		: base(0, null)
	{
	}

	public OobCert(X509CertificateStructure x509v3PKCert)
		: base(0, null)
	{
	}
}
