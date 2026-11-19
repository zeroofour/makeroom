using System;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class CommitmentTypeIndication : Asn1Encodable
{
	private readonly DerObjectIdentifier m_commitmentTypeId;

	private readonly Asn1Sequence m_commitmentTypeQualifier;

	public DerObjectIdentifier CommitmentTypeID => null;

	public Asn1Sequence CommitmentTypeQualifier => null;

	public static CommitmentTypeIndication GetInstance(object obj)
	{
		return null;
	}

	public static CommitmentTypeIndication GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	[Obsolete("Use 'GetInstance' instead")]
	public CommitmentTypeIndication(Asn1Sequence seq)
	{
	}

	public CommitmentTypeIndication(DerObjectIdentifier commitmentTypeId)
	{
	}

	public CommitmentTypeIndication(DerObjectIdentifier commitmentTypeId, Asn1Sequence commitmentTypeQualifier)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
