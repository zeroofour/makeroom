using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Parameters;

public class RsaKeyGenerationParameters : KeyGenerationParameters
{
	private readonly BigInteger publicExponent;

	private readonly int certainty;

	public BigInteger PublicExponent => null;

	public int Certainty => 0;

	public RsaKeyGenerationParameters(BigInteger publicExponent, SecureRandom random, int strength, int certainty)
		: base(null, 0)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
