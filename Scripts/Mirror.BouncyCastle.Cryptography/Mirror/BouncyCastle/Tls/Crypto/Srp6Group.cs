using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Tls.Crypto;

public class Srp6Group
{
	private readonly BigInteger n;

	private readonly BigInteger g;

	public virtual BigInteger G => null;

	public virtual BigInteger N => null;

	public Srp6Group(BigInteger n, BigInteger g)
	{
	}
}
