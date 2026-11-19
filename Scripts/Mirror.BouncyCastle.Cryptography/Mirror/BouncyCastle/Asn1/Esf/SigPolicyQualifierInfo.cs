using System;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class SigPolicyQualifierInfo : Asn1Encodable
{
	private readonly DerObjectIdentifier m_sigPolicyQualifierId;

	private readonly Asn1Encodable m_sigQualifier;

	public DerObjectIdentifier SigPolicyQualifierId => null;

	public Asn1Encodable SigQualifierData => null;

	[Obsolete("Use 'SigQualifierData' instead")]
	public Asn1Object SigQualifier => null;

	public static SigPolicyQualifierInfo GetInstance(object obj)
	{
		return null;
	}

	public static SigPolicyQualifierInfo GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private SigPolicyQualifierInfo(Asn1Sequence seq)
	{
	}

	public SigPolicyQualifierInfo(DerObjectIdentifier sigPolicyQualifierId, Asn1Encodable sigQualifier)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
