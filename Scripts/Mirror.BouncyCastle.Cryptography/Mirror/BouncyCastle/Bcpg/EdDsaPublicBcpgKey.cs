using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Math.EC;

namespace Mirror.BouncyCastle.Bcpg;

public sealed class EdDsaPublicBcpgKey : ECPublicBcpgKey
{
	internal EdDsaPublicBcpgKey(BcpgInputStream bcpgIn)
		: base(null)
	{
	}

	public EdDsaPublicBcpgKey(DerObjectIdentifier oid, ECPoint point)
		: base(null)
	{
	}

	public EdDsaPublicBcpgKey(DerObjectIdentifier oid, BigInteger encodedPoint)
		: base(null)
	{
	}
}
