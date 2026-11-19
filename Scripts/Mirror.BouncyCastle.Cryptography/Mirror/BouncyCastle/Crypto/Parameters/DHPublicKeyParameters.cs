using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Crypto.Parameters;

public class DHPublicKeyParameters : DHKeyParameters
{
	private readonly BigInteger m_y;

	public virtual BigInteger Y => null;

	private static BigInteger Validate(BigInteger y, DHParameters dhParams)
	{
		return null;
	}

	public DHPublicKeyParameters(BigInteger y, DHParameters parameters)
		: base(isPrivate: false, null)
	{
	}

	public DHPublicKeyParameters(BigInteger y, DHParameters parameters, DerObjectIdentifier algorithmOid)
		: base(isPrivate: false, null)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	protected bool Equals(DHPublicKeyParameters other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	private static int Legendre(BigInteger a, BigInteger b)
	{
		return 0;
	}
}
