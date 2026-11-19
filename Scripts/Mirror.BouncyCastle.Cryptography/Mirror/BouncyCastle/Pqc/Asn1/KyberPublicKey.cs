using System;
using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Pqc.Asn1;

[Obsolete("Will be removed as this draft proposal was rejected")]
public sealed class KyberPublicKey : Asn1Encodable
{
	private readonly byte[] m_t;

	private readonly byte[] m_rho;

	public byte[] T => null;

	public byte[] Rho => null;

	public static KyberPublicKey GetInstance(object obj)
	{
		return null;
	}

	public static KyberPublicKey GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public KyberPublicKey(byte[] t, byte[] rho)
	{
	}

	private KyberPublicKey(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
