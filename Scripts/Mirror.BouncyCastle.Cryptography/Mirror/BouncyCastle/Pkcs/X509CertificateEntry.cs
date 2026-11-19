using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Pkcs;

public class X509CertificateEntry : Pkcs12Entry
{
	private readonly X509Certificate cert;

	public X509Certificate Certificate => null;

	public X509CertificateEntry(X509Certificate cert)
		: base(null)
	{
	}

	public X509CertificateEntry(X509Certificate cert, IDictionary<DerObjectIdentifier, Asn1Encodable> attributes)
		: base(null)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
