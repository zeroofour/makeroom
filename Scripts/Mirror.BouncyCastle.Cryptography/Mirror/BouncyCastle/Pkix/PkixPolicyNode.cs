using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Pkix;

public class PkixPolicyNode
{
	protected IList<PkixPolicyNode> mChildren;

	protected int mDepth;

	protected ISet<string> mExpectedPolicies;

	protected PkixPolicyNode mParent;

	protected ISet<PolicyQualifierInfo> mPolicyQualifiers;

	protected string mValidPolicy;

	protected bool mCritical;

	public virtual int Depth => 0;

	public virtual IEnumerable<PkixPolicyNode> Children => null;

	public virtual bool IsCritical
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual ISet<PolicyQualifierInfo> PolicyQualifiers => null;

	public virtual string ValidPolicy => null;

	public virtual bool HasChildren => false;

	public virtual ISet<string> ExpectedPolicies
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual PkixPolicyNode Parent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public PkixPolicyNode(IEnumerable<PkixPolicyNode> children, int depth, ISet<string> expectedPolicies, PkixPolicyNode parent, ISet<PolicyQualifierInfo> policyQualifiers, string validPolicy, bool critical)
	{
	}

	public virtual void AddChild(PkixPolicyNode child)
	{
	}

	public virtual void RemoveChild(PkixPolicyNode child)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public virtual string ToString(string indent)
	{
		return null;
	}

	public virtual object Clone()
	{
		return null;
	}

	public virtual PkixPolicyNode Copy()
	{
		return null;
	}
}
