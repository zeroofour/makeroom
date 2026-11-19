using System.Collections.Generic;
using Mirror.BouncyCastle.Utilities.Collections;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Pkix;

public class PkixBuilderParameters : PkixParameters
{
	private int maxPathLength;

	private HashSet<X509Certificate> excludedCerts;

	public virtual int MaxPathLength
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static PkixBuilderParameters GetInstance(PkixParameters pkixParams)
	{
		return null;
	}

	public PkixBuilderParameters(ISet<TrustAnchor> trustAnchors, ISelector<X509Certificate> targetConstraintsCert)
		: base(null)
	{
	}

	public PkixBuilderParameters(ISet<TrustAnchor> trustAnchors, ISelector<X509Certificate> targetConstraintsCert, ISelector<X509V2AttributeCertificate> targetConstraintsAttrCert)
		: base(null)
	{
	}

	public virtual ISet<X509Certificate> GetExcludedCerts()
	{
		return null;
	}

	public virtual void SetExcludedCerts(ISet<X509Certificate> excludedCerts)
	{
	}

	protected override void SetParams(PkixParameters parameters)
	{
	}

	public override object Clone()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
