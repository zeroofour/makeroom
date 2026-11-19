using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Tls.Crypto;

public class DHGroup
{
	private readonly BigInteger g;

	private readonly BigInteger p;

	private readonly BigInteger q;

	private readonly int l;

	public virtual BigInteger G => null;

	public virtual int L => 0;

	public virtual BigInteger P => null;

	public virtual BigInteger Q => null;

	public DHGroup(BigInteger p, BigInteger q, BigInteger g, int l)
	{
	}
}
