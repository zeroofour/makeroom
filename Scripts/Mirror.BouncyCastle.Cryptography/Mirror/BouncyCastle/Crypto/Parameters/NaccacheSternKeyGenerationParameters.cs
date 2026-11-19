using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Parameters;

public class NaccacheSternKeyGenerationParameters : KeyGenerationParameters
{
	private readonly int certainty;

	private readonly int countSmallPrimes;

	public int Certainty => 0;

	public int CountSmallPrimes => 0;

	public NaccacheSternKeyGenerationParameters(SecureRandom random, int strength, int certainty, int countSmallPrimes)
		: base(null, 0)
	{
	}
}
