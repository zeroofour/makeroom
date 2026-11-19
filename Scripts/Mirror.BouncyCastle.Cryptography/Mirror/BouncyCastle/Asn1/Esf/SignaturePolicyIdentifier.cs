namespace Mirror.BouncyCastle.Asn1.Esf;

public class SignaturePolicyIdentifier : Asn1Encodable, IAsn1Choice
{
	private readonly SignaturePolicyId m_sigPolicy;

	public SignaturePolicyId SignaturePolicyId => null;

	public static SignaturePolicyIdentifier GetInstance(object obj)
	{
		return null;
	}

	public static SignaturePolicyIdentifier GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public SignaturePolicyIdentifier()
	{
	}

	public SignaturePolicyIdentifier(SignaturePolicyId signaturePolicyId)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
