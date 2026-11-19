using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Pkix;

public class PkixCertPathBuilder
{
	private Exception certPathException;

	public virtual PkixCertPathBuilderResult Build(PkixBuilderParameters pkixParams)
	{
		return null;
	}

	protected virtual PkixCertPathBuilderResult Build(X509Certificate tbvCert, PkixBuilderParameters pkixParams, IList<X509Certificate> tbvPath)
	{
		return null;
	}
}
