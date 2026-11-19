using System;
using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1.X509;

public class NameConstraints : Asn1Encodable
{
	private readonly Asn1Sequence m_permitted;

	private readonly Asn1Sequence m_excluded;

	public Asn1Sequence PermittedSubtrees => null;

	public Asn1Sequence ExcludedSubtrees => null;

	public static NameConstraints GetInstance(object obj)
	{
		return null;
	}

	public static NameConstraints GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	[Obsolete("Use 'GetInstance' instead")]
	public NameConstraints(Asn1Sequence seq)
	{
	}

	public NameConstraints(IList<GeneralSubtree> permitted, IList<GeneralSubtree> excluded)
	{
	}

	private DerSequence CreateSequence(IList<GeneralSubtree> subtrees)
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
