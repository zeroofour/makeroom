using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Tsp;

public class TstInfo : Asn1Encodable
{
	private readonly DerInteger m_version;

	private readonly DerObjectIdentifier m_tsaPolicyID;

	private readonly MessageImprint m_messageImprint;

	private readonly DerInteger m_serialNumber;

	private readonly Asn1GeneralizedTime m_genTime;

	private readonly Accuracy m_accuracy;

	private readonly DerBoolean m_ordering;

	private readonly DerInteger m_nonce;

	private readonly GeneralName m_tsa;

	private readonly X509Extensions m_extensions;

	public DerInteger Version => null;

	public MessageImprint MessageImprint => null;

	public DerObjectIdentifier Policy => null;

	public DerInteger SerialNumber => null;

	public Accuracy Accuracy => null;

	public Asn1GeneralizedTime GenTime => null;

	public DerBoolean Ordering => null;

	public DerInteger Nonce => null;

	public GeneralName Tsa => null;

	public X509Extensions Extensions => null;

	public static TstInfo GetInstance(object obj)
	{
		return null;
	}

	public static TstInfo GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private TstInfo(Asn1Sequence seq)
	{
	}

	public TstInfo(DerObjectIdentifier tsaPolicyId, MessageImprint messageImprint, DerInteger serialNumber, Asn1GeneralizedTime genTime, Accuracy accuracy, DerBoolean ordering, DerInteger nonce, GeneralName tsa, X509Extensions extensions)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
