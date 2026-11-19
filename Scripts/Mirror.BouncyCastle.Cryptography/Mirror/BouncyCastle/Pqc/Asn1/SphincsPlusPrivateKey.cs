using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Pqc.Asn1;

public sealed class SphincsPlusPrivateKey : Asn1Encodable
{
	private readonly int m_version;

	private readonly byte[] m_skseed;

	private readonly byte[] m_skprf;

	private readonly SphincsPlusPublicKey m_publicKey;

	public SphincsPlusPublicKey PublicKey => null;

	public int Version => 0;

	public static SphincsPlusPrivateKey GetInstance(object obj)
	{
		return null;
	}

	public static SphincsPlusPrivateKey GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public SphincsPlusPrivateKey(int version, byte[] skseed, byte[] skprf)
	{
	}

	public SphincsPlusPrivateKey(int version, byte[] skseed, byte[] skprf, SphincsPlusPublicKey publicKey)
	{
	}

	private SphincsPlusPrivateKey(Asn1Sequence seq)
	{
	}

	public byte[] GetSkprf()
	{
		return null;
	}

	public byte[] GetSkseed()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
