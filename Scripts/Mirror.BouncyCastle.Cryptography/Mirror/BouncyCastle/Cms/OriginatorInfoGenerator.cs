using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Utilities.Collections;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cms;

public class OriginatorInfoGenerator
{
	private readonly List<Asn1Encodable> origCerts;

	private readonly List<Asn1Encodable> origCrls;

	public OriginatorInfoGenerator(X509Certificate origCert)
	{
	}

	public OriginatorInfoGenerator(IStore<X509Certificate> x509Certs)
	{
	}

	public OriginatorInfoGenerator(IStore<X509Certificate> x509Certs, IStore<X509Crl> x509Crls)
	{
	}

	public OriginatorInfoGenerator(IStore<X509Certificate> x509Certs, IStore<X509Crl> x509Crls, IStore<X509V2AttributeCertificate> x509AttrCerts, IStore<OtherRevocationInfoFormat> otherRevocationInfos)
	{
	}

	public virtual OriginatorInfo Generate()
	{
		return null;
	}
}
