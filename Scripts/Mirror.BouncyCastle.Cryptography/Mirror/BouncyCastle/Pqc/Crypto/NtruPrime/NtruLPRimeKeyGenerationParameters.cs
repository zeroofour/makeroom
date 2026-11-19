using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.NtruPrime;

public class NtruLPRimeKeyGenerationParameters : KeyGenerationParameters
{
	private NtruLPRimeParameters _primeParameters;

	public NtruLPRimeParameters Parameters => null;

	public NtruLPRimeKeyGenerationParameters(SecureRandom random, NtruLPRimeParameters ntruPrimeParameters)
		: base(null, 0)
	{
	}
}
