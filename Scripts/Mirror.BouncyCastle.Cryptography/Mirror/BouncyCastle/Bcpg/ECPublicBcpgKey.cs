using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Math.EC;

namespace Mirror.BouncyCastle.Bcpg;

public abstract class ECPublicBcpgKey : BcpgObject, IBcpgKey
{
	internal DerObjectIdentifier oid;

	internal BigInteger point;

	public string Format => null;

	public virtual BigInteger EncodedPoint => null;

	public virtual DerObjectIdentifier CurveOid => null;

	protected ECPublicBcpgKey(BcpgInputStream bcpgIn)
	{
	}

	protected ECPublicBcpgKey(DerObjectIdentifier oid, ECPoint point)
	{
	}

	protected ECPublicBcpgKey(DerObjectIdentifier oid, BigInteger encodedPoint)
	{
	}

	public override byte[] GetEncoded()
	{
		return null;
	}

	public override void Encode(BcpgOutputStream bcpgOut)
	{
	}

	protected static byte[] ReadBytesOfEncodedLength(BcpgInputStream bcpgIn)
	{
		return null;
	}
}
