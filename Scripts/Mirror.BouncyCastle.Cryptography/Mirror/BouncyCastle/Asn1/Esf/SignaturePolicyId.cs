using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class SignaturePolicyId : Asn1Encodable
{
	private readonly DerObjectIdentifier m_sigPolicyIdentifier;

	private readonly OtherHashAlgAndValue m_sigPolicyHash;

	private readonly Asn1Sequence m_sigPolicyQualifiers;

	public DerObjectIdentifier SigPolicyIdentifier => null;

	public OtherHashAlgAndValue SigPolicyHash => null;

	public static SignaturePolicyId GetInstance(object obj)
	{
		return null;
	}

	public static SignaturePolicyId GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private SignaturePolicyId(Asn1Sequence seq)
	{
	}

	public SignaturePolicyId(DerObjectIdentifier sigPolicyIdentifier, OtherHashAlgAndValue sigPolicyHash)
	{
	}

	public SignaturePolicyId(DerObjectIdentifier sigPolicyIdentifier, OtherHashAlgAndValue sigPolicyHash, params SigPolicyQualifierInfo[] sigPolicyQualifiers)
	{
	}

	public SignaturePolicyId(DerObjectIdentifier sigPolicyIdentifier, OtherHashAlgAndValue sigPolicyHash, IEnumerable<SigPolicyQualifierInfo> sigPolicyQualifiers)
	{
	}

	public SigPolicyQualifierInfo[] GetSigPolicyQualifiers()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
