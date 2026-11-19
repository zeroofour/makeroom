using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Tsp;

public class TimeStampReq : Asn1Encodable
{
	private readonly DerInteger m_version;

	private readonly MessageImprint m_messageImprint;

	private readonly DerObjectIdentifier m_tsaPolicy;

	private readonly DerInteger m_nonce;

	private readonly DerBoolean m_certReq;

	private readonly X509Extensions m_extensions;

	public DerInteger Version => null;

	public MessageImprint MessageImprint => null;

	public DerObjectIdentifier ReqPolicy => null;

	public DerInteger Nonce => null;

	public DerBoolean CertReq => null;

	public X509Extensions Extensions => null;

	public static TimeStampReq GetInstance(object obj)
	{
		return null;
	}

	public static TimeStampReq GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private TimeStampReq(Asn1Sequence seq)
	{
	}

	public TimeStampReq(MessageImprint messageImprint, DerObjectIdentifier tsaPolicy, DerInteger nonce, DerBoolean certReq, X509Extensions extensions)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
