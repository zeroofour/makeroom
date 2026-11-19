using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Generators;

public class RsaBlindingFactorGenerator
{
	private RsaKeyParameters key;

	private SecureRandom random;

	public void Init(ICipherParameters param)
	{
	}

	public BigInteger GenerateBlindingFactor()
	{
		return null;
	}
}
