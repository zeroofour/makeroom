using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Math.EC;

namespace Mirror.BouncyCastle.Crypto.Parameters;

public class ECPublicKeyParameters : ECKeyParameters
{
	private readonly ECPoint q;

	public ECPoint Q => null;

	public ECPublicKeyParameters(ECPoint q, ECDomainParameters parameters)
		: base((string)null, false, (ECDomainParameters)null)
	{
	}

	public ECPublicKeyParameters(string algorithm, ECPoint q, ECDomainParameters parameters)
		: base((string)null, false, (ECDomainParameters)null)
	{
	}

	public ECPublicKeyParameters(string algorithm, ECPoint q, DerObjectIdentifier publicKeyParamSet)
		: base((string)null, false, (ECDomainParameters)null)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	protected bool Equals(ECPublicKeyParameters other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
