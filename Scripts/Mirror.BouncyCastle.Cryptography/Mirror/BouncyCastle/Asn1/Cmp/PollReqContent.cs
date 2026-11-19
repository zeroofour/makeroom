using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class PollReqContent : Asn1Encodable
{
	private readonly Asn1Sequence m_content;

	public static PollReqContent GetInstance(object obj)
	{
		return null;
	}

	public static PollReqContent GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private PollReqContent(Asn1Sequence seq)
	{
	}

	public PollReqContent(DerInteger certReqId)
	{
	}

	public PollReqContent(DerInteger[] certReqIds)
	{
	}

	public PollReqContent(BigInteger certReqId)
	{
	}

	public PollReqContent(BigInteger[] certReqIds)
	{
	}

	public virtual DerInteger[][] GetCertReqIDs()
	{
		return null;
	}

	public virtual BigInteger[] GetCertReqIDValues()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}

	private static DerSequence[] IntsToSequence(DerInteger[] ids)
	{
		return null;
	}

	private static DerInteger[] IntsToAsn1(BigInteger[] ids)
	{
		return null;
	}
}
