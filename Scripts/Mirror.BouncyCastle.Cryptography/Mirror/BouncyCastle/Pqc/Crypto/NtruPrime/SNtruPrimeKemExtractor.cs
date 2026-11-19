using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.NtruPrime;

public class SNtruPrimeKemExtractor : IEncapsulatedSecretExtractor
{
	private NtruPrimeEngine _primeEngine;

	private readonly SNtruPrimeKeyParameters _primeKey;

	public int EncapsulationLength => 0;

	public SNtruPrimeKemExtractor(SNtruPrimeKeyParameters privParams)
	{
	}

	private void InitCipher(SNtruPrimeParameters param)
	{
	}

	public byte[] ExtractSecret(byte[] encapsulation)
	{
		return null;
	}
}
