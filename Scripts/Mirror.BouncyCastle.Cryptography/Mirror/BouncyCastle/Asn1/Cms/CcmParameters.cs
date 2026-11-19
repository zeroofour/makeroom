namespace Mirror.BouncyCastle.Asn1.Cms;

public class CcmParameters : Asn1Encodable
{
	private const int DefaultIcvLen = 12;

	private readonly byte[] m_nonce;

	private readonly int m_icvLen;

	public int IcvLen => 0;

	public static CcmParameters GetInstance(object obj)
	{
		return null;
	}

	public static CcmParameters GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CcmParameters(Asn1Sequence seq)
	{
	}

	public CcmParameters(byte[] nonce, int icvLen)
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
