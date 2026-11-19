using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Cmce;

public sealed class CmceKemExtractor : IEncapsulatedSecretExtractor
{
	private ICmceEngine engine;

	private CmceKeyParameters key;

	public int EncapsulationLength => 0;

	public CmceKemExtractor(CmcePrivateKeyParameters privParams)
	{
	}

	private void InitCipher(CmceParameters param)
	{
	}

	public byte[] ExtractSecret(byte[] encapsulation)
	{
		return null;
	}

	private byte[] ExtractSecret(byte[] encapsulation, int sessionKeySizeInBits)
	{
		return null;
	}
}
