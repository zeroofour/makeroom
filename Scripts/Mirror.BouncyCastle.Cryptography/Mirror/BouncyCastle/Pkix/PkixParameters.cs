using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Utilities.Collections;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Pkix;

public class PkixParameters
{
	public const int PkixValidityModel = 0;

	public const int ChainValidityModel = 1;

	private HashSet<TrustAnchor> trustAnchors;

	private DateTime? date;

	private List<PkixCertPathChecker> m_checkers;

	private bool revocationEnabled;

	private HashSet<string> initialPolicies;

	private bool explicitPolicyRequired;

	private bool anyPolicyInhibited;

	private bool policyMappingInhibited;

	private bool policyQualifiersRejected;

	private List<IStore<X509V2AttributeCertificate>> m_storesAttrCert;

	private List<IStore<X509Certificate>> m_storesCert;

	private List<IStore<X509Crl>> m_storesCrl;

	private ISelector<X509V2AttributeCertificate> m_targetConstraintsAttrCert;

	private ISelector<X509Certificate> m_targetConstraintsCert;

	private bool additionalLocationsEnabled;

	private HashSet<TrustAnchor> trustedACIssuers;

	private HashSet<string> necessaryACAttributes;

	private HashSet<string> prohibitedACAttributes;

	private HashSet<PkixAttrCertChecker> attrCertCheckers;

	private int validityModel;

	private bool useDeltas;

	public virtual bool IsRevocationEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual bool IsExplicitPolicyRequired
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual bool IsAnyPolicyInhibited
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual bool IsPolicyMappingInhibited
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual bool IsPolicyQualifiersRejected
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual DateTime? Date
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual bool IsUseDeltasEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual int ValidityModel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual bool IsAdditionalLocationsEnabled => false;

	public PkixParameters(ISet<TrustAnchor> trustAnchors)
	{
	}

	public virtual ISet<TrustAnchor> GetTrustAnchors()
	{
		return null;
	}

	public virtual void SetTrustAnchors(ISet<TrustAnchor> tas)
	{
	}

	public virtual ISelector<X509V2AttributeCertificate> GetTargetConstraintsAttrCert()
	{
		return null;
	}

	public virtual void SetTargetConstraintsAttrCert(ISelector<X509V2AttributeCertificate> targetConstraintsAttrCert)
	{
	}

	public virtual ISelector<X509Certificate> GetTargetConstraintsCert()
	{
		return null;
	}

	public virtual void SetTargetConstraintsCert(ISelector<X509Certificate> targetConstraintsCert)
	{
	}

	public virtual ISet<string> GetInitialPolicies()
	{
		return null;
	}

	public virtual void SetInitialPolicies(ISet<string> initialPolicies)
	{
	}

	public virtual void SetCertPathCheckers(IList<PkixCertPathChecker> checkers)
	{
	}

	public virtual IList<PkixCertPathChecker> GetCertPathCheckers()
	{
		return null;
	}

	public virtual void AddCertPathChecker(PkixCertPathChecker checker)
	{
	}

	public virtual object Clone()
	{
		return null;
	}

	protected virtual void SetParams(PkixParameters parameters)
	{
	}

	public virtual IList<IStore<X509V2AttributeCertificate>> GetStoresAttrCert()
	{
		return null;
	}

	public virtual IList<IStore<X509Certificate>> GetStoresCert()
	{
		return null;
	}

	public virtual IList<IStore<X509Crl>> GetStoresCrl()
	{
		return null;
	}

	[Obsolete("Use 'SetStoresAttrCert' instead")]
	public virtual void SetAttrStoresCert(IList<IStore<X509V2AttributeCertificate>> storesAttrCert)
	{
	}

	public virtual void SetStoresAttrCert(IList<IStore<X509V2AttributeCertificate>> storesAttrCert)
	{
	}

	public virtual void SetStoresCert(IList<IStore<X509Certificate>> storesCert)
	{
	}

	public virtual void SetStoresCrl(IList<IStore<X509Crl>> storesCrl)
	{
	}

	public virtual void AddStoreAttrCert(IStore<X509V2AttributeCertificate> storeAttrCert)
	{
	}

	public virtual void AddStoreCert(IStore<X509Certificate> storeCert)
	{
	}

	public virtual void AddStoreCrl(IStore<X509Crl> storeCrl)
	{
	}

	public virtual void SetAdditionalLocationsEnabled(bool enabled)
	{
	}

	public virtual ISet<TrustAnchor> GetTrustedACIssuers()
	{
		return null;
	}

	public virtual void SetTrustedACIssuers(ISet<TrustAnchor> trustedACIssuers)
	{
	}

	public virtual ISet<string> GetNecessaryACAttributes()
	{
		return null;
	}

	public virtual void SetNecessaryACAttributes(ISet<string> necessaryACAttributes)
	{
	}

	public virtual ISet<string> GetProhibitedACAttributes()
	{
		return null;
	}

	public virtual void SetProhibitedACAttributes(ISet<string> prohibitedACAttributes)
	{
	}

	public virtual ISet<PkixAttrCertChecker> GetAttrCertCheckers()
	{
		return null;
	}

	public virtual void SetAttrCertCheckers(ISet<PkixAttrCertChecker> attrCertCheckers)
	{
	}
}
