using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Utilities.Collections;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Pkix;

public class PkixAttrCertPathBuilder
{
	private Exception certPathException;

	public virtual PkixCertPathBuilderResult Build(PkixBuilderParameters pkixParams)
	{
		return null;
	}

	private PkixCertPathBuilderResult Build(X509V2AttributeCertificate attrCert, X509Certificate tbvCert, PkixBuilderParameters pkixParams, IList<X509Certificate> tbvPath)
	{
		return null;
	}

	internal static HashSet<X509V2AttributeCertificate> FindAttributeCertificates(ISelector<X509V2AttributeCertificate> attrCertSelector, IList<IStore<X509V2AttributeCertificate>> attrCertStores)
	{
		return null;
	}
}
