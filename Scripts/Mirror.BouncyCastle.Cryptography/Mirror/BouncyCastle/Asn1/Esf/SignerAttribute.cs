using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class SignerAttribute : Asn1Encodable
{
	private readonly Asn1Sequence m_claimedAttributes;

	private readonly AttributeCertificate m_certifiedAttributes;

	public virtual Asn1Sequence ClaimedAttributes => null;

	public virtual AttributeCertificate CertifiedAttributes => null;

	public static SignerAttribute GetInstance(object obj)
	{
		return null;
	}

	private SignerAttribute(Asn1Sequence seq, bool dummy)
	{
	}

	public SignerAttribute(Asn1Sequence claimedAttributes)
	{
	}

	public SignerAttribute(AttributeCertificate certifiedAttributes)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
