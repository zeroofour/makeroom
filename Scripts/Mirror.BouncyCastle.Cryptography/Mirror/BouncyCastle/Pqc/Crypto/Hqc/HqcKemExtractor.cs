using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Hqc;

public class HqcKemExtractor : IEncapsulatedSecretExtractor
{
	private HqcEngine engine;

	private HqcKeyParameters key;

	public int EncapsulationLength => 0;

	public HqcKemExtractor(HqcPrivateKeyParameters privParams)
	{
	}

	private void InitCipher(HqcParameters param)
	{
	}

	public byte[] ExtractSecret(byte[] encapsulation)
	{
		return null;
	}
}
