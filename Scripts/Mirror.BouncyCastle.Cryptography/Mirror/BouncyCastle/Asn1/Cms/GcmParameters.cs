namespace Mirror.BouncyCastle.Asn1.Cms;

public class GcmParameters : Asn1Encodable
{
	private const int DefaultIcvLen = 12;

	private readonly byte[] m_nonce;

	private readonly int m_icvLen;

	public int IcvLen => 0;

	public static GcmParameters GetInstance(object obj)
	{
		return null;
	}

	public static GcmParameters GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private GcmParameters(Asn1Sequence seq)
	{
	}

	public GcmParameters(byte[] nonce, int icvLen)
	{
	}

	public byte[] GetNonce()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
