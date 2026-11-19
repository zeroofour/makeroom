using System;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class CommitmentTypeQualifier : Asn1Encodable
{
	private readonly DerObjectIdentifier m_commitmentTypeIdentifier;

	private readonly Asn1Encodable m_qualifier;

	public DerObjectIdentifier CommitmentTypeIdentifier => null;

	public Asn1Encodable QualifierData => null;

	[Obsolete("Use 'QualifierData' instead")]
	public Asn1Object Qualifier => null;

	public static CommitmentTypeQualifier GetInstance(object obj)
	{
		return null;
	}

	public static CommitmentTypeQualifier GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public CommitmentTypeQualifier(DerObjectIdentifier commitmentTypeIdentifier)
	{
	}

	public CommitmentTypeQualifier(DerObjectIdentifier commitmentTypeIdentifier, Asn1Encodable qualifier)
	{
	}

	[Obsolete("Use 'GetInstance' instead")]
	public CommitmentTypeQualifier(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
