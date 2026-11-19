using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Crypto.Parameters;

public class DHPrivateKeyParameters : DHKeyParameters
{
	private readonly BigInteger x;

	public BigInteger X => null;

	public DHPrivateKeyParameters(BigInteger x, DHParameters parameters)
		: base(isPrivate: false, null)
	{
	}

	public DHPrivateKeyParameters(BigInteger x, DHParameters parameters, DerObjectIdentifier algorithmOid)
		: base(isPrivate: false, null)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	protected bool Equals(DHPrivateKeyParameters other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
