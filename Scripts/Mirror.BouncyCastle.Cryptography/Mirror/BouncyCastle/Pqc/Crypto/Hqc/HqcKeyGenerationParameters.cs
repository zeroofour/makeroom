using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Hqc;

public class HqcKeyGenerationParameters : KeyGenerationParameters
{
	private HqcParameters param;

	public HqcParameters Parameters => null;

	public HqcKeyGenerationParameters(SecureRandom random, HqcParameters param)
		: base(null, 0)
	{
	}
}
