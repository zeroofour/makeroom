using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.NtruPrime;

public class NtruLPRimeKemExtractor : IEncapsulatedSecretExtractor
{
	private NtruPrimeEngine _primeEngine;

	private readonly NtruLPRimeKeyParameters _primeKey;

	public int EncapsulationLength => 0;

	public NtruLPRimeKemExtractor(NtruLPRimeKeyParameters privParams)
	{
	}

	private void InitCipher(NtruLPRimeParameters param)
	{
	}

	public byte[] ExtractSecret(byte[] encapsulation)
	{
		return null;
	}
}
