using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Pqc.Asn1;

public sealed class KyberPrivateKey : Asn1Encodable
{
	private int version;

	private byte[] s;

	private KyberPublicKey publicKey;

	private byte[] hpk;

	private byte[] nonce;

	public int Version => 0;

	public KyberPublicKey PublicKey => null;

	public static KyberPrivateKey GetInstance(object obj)
	{
		return null;
	}

	public static KyberPrivateKey GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public KyberPrivateKey(int version, byte[] s, byte[] hpk, byte[] nonce, KyberPublicKey publicKey)
	{
	}

	public KyberPrivateKey(int version, byte[] s, byte[] hpk, byte[] nonce)
	{
	}

	private KyberPrivateKey(Asn1Sequence seq)
	{
	}

	public byte[] GetS()
	{
		return null;
	}

	public byte[] GetHpk()
	{
		return null;
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
