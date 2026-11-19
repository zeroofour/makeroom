using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Saber;

public sealed class SaberKemExtractor : IEncapsulatedSecretExtractor
{
	private readonly SaberKeyParameters key;

	private SaberEngine engine;

	public int EncapsulationLength => 0;

	public SaberKemExtractor(SaberKeyParameters privParams)
	{
	}

	private void InitCipher(SaberParameters param)
	{
	}

	public byte[] ExtractSecret(byte[] encapsulation)
	{
		return null;
	}
}
