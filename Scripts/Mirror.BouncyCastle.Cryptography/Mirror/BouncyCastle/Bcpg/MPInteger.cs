using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Math.EC;

namespace Mirror.BouncyCastle.Bcpg;

public sealed class MPInteger : BcpgObject
{
	private readonly BigInteger m_val;

	public BigInteger Value => null;

	public MPInteger(BcpgInputStream bcpgIn)
	{
	}

	public MPInteger(BigInteger val)
	{
	}

	public override void Encode(BcpgOutputStream bcpgOut)
	{
	}

	internal static BigInteger ToMpiBigInteger(ECPoint point)
	{
		return null;
	}
}
