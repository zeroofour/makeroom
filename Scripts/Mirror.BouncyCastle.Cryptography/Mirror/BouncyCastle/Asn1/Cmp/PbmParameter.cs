using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class PbmParameter : Asn1Encodable
{
	private readonly Asn1OctetString m_salt;

	private readonly AlgorithmIdentifier m_owf;

	private readonly DerInteger m_iterationCount;

	private readonly AlgorithmIdentifier m_mac;

	public virtual DerInteger IterationCount => null;

	public virtual AlgorithmIdentifier Mac => null;

	public virtual AlgorithmIdentifier Owf => null;

	public virtual Asn1OctetString Salt => null;

	public static PbmParameter GetInstance(object obj)
	{
		return null;
	}

	public static PbmParameter GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private PbmParameter(Asn1Sequence seq)
	{
	}

	public PbmParameter(byte[] salt, AlgorithmIdentifier owf, int iterationCount, AlgorithmIdentifier mac)
	{
	}

	public PbmParameter(Asn1OctetString salt, AlgorithmIdentifier owf, DerInteger iterationCount, AlgorithmIdentifier mac)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
