using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Pkix;

internal static class Rfc3281CertPathUtilities
{
	internal static void ProcessAttrCert7(X509V2AttributeCertificate attrCert, PkixCertPath certPath, PkixCertPath holderCertPath, PkixParameters pkixParams)
	{
	}

	internal static void CheckCrls(X509V2AttributeCertificate attrCert, PkixParameters paramsPKIX, X509Certificate issuerCert, DateTime validDate, IList<X509Certificate> certPathCerts)
	{
	}

	internal static void AdditionalChecks(X509V2AttributeCertificate attrCert, PkixParameters pkixParams)
	{
	}

	internal static void ProcessAttrCert5(X509V2AttributeCertificate attrCert, PkixParameters pkixParams)
	{
	}

	internal static void ProcessAttrCert4(X509Certificate acIssuerCert, PkixParameters pkixParams)
	{
	}

	internal static void ProcessAttrCert3(X509Certificate acIssuerCert, PkixParameters pkixParams)
	{
	}

	internal static PkixCertPathValidatorResult ProcessAttrCert2(PkixCertPath certPath, PkixParameters pkixParams)
	{
		return null;
	}

	internal static PkixCertPath ProcessAttrCert1(X509V2AttributeCertificate attrCert, PkixParameters pkixParams)
	{
		return null;
	}

	private static void CheckCrl(DistributionPoint dp, X509V2AttributeCertificate attrCert, PkixParameters paramsPKIX, DateTime validDate, X509Certificate issuerCert, CertStatus certStatus, ReasonsMask reasonMask, IList<X509Certificate> certPathCerts)
	{
	}
}
