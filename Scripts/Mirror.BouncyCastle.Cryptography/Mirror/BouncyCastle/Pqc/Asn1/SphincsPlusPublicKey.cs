using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Pqc.Asn1;

public sealed class SphincsPlusPublicKey : Asn1Encodable
{
	private readonly byte[] m_pkseed;

	private readonly byte[] m_pkroot;

	public static SphincsPlusPublicKey GetInstance(object obj)
	{
		return null;
	}

	public static SphincsPlusPublicKey GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public SphincsPlusPublicKey(byte[] pkseed, byte[] pkroot)
	{
	}

	private SphincsPlusPublicKey(Asn1Sequence seq)
	{
	}

	public byte[] GetPkroot()
	{
		return null;
	}

	public byte[] GetPkseed()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
