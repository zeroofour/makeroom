using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Asn1.Sec;

public class ECPrivateKeyStructure : Asn1Encodable
{
	private readonly Asn1Sequence m_seq;

	public static ECPrivateKeyStructure GetInstance(object obj)
	{
		return null;
	}

	private ECPrivateKeyStructure(Asn1Sequence seq)
	{
	}

	public ECPrivateKeyStructure(int orderBitLength, BigInteger key)
	{
	}

	public ECPrivateKeyStructure(int orderBitLength, BigInteger key, Asn1Encodable parameters)
	{
	}

	public ECPrivateKeyStructure(int orderBitLength, BigInteger key, DerBitString publicKey, Asn1Encodable parameters)
	{
	}

	public virtual BigInteger GetKey()
	{
		return null;
	}

	public virtual DerBitString GetPublicKey()
	{
		return null;
	}

	public virtual Asn1Object GetParameters()
	{
		return null;
	}

	private Asn1Object GetObjectInTag(int tagNo, int baseTagNo)
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
