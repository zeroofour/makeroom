using System;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.X509;

[Obsolete("Will be removed")]
public class PrincipalUtilities
{
	public static X509Name GetIssuerX509Principal(X509Certificate cert)
	{
		return null;
	}

	public static X509Name GetSubjectX509Principal(X509Certificate cert)
	{
		return null;
	}

	public static X509Name GetIssuerX509Principal(X509Crl crl)
	{
		return null;
	}
}
