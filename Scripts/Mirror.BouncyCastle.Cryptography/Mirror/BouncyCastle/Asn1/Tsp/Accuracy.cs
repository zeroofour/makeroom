namespace Mirror.BouncyCastle.Asn1.Tsp;

public class Accuracy : Asn1Encodable
{
	protected const int MinMillis = 1;

	protected const int MaxMillis = 999;

	protected const int MinMicros = 1;

	protected const int MaxMicros = 999;

	private readonly DerInteger m_seconds;

	private readonly DerInteger m_millis;

	private readonly DerInteger m_micros;

	public DerInteger Seconds => null;

	public DerInteger Millis => null;

	public DerInteger Micros => null;

	public static Accuracy GetInstance(object obj)
	{
		return null;
	}

	public static Accuracy GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public Accuracy(DerInteger seconds, DerInteger millis, DerInteger micros)
	{
	}

	private Accuracy(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
