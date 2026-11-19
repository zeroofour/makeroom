using System;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Utilities.Collections;

namespace Mirror.BouncyCastle.X509;

public class AttributeCertificateIssuer : ISelector<X509Certificate>, ICloneable
{
	internal readonly Asn1Encodable form;

	public AttributeCertificateIssuer(AttCertIssuer issuer)
	{
	}

	public AttributeCertificateIssuer(X509Name principal)
	{
	}

	private object[] GetNames()
	{
		return null;
	}

	public X509Name[] GetPrincipals()
	{
		return null;
	}

	private bool MatchesDN(X509Name subject, GeneralNames targets)
	{
		return false;
	}

	public object Clone()
	{
		return null;
	}

	public bool Match(X509Certificate x509Cert)
	{
		return false;
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
