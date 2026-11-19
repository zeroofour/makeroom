using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.NtruPrime;

public class SNtruPrimeKeyGenerationParameters : KeyGenerationParameters
{
	private SNtruPrimeParameters _primeParameters;

	public SNtruPrimeParameters Parameters => null;

	public SNtruPrimeKeyGenerationParameters(SecureRandom random, SNtruPrimeParameters ntruPrimeParameters)
		: base(null, 0)
	{
	}
}
