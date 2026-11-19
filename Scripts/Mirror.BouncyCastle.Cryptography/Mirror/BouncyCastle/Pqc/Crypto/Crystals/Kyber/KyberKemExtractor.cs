using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Kyber;

public sealed class KyberKemExtractor : IEncapsulatedSecretExtractor
{
	private readonly KyberKeyParameters m_key;

	private readonly KyberEngine m_engine;

	public int EncapsulationLength => 0;

	public KyberKemExtractor(KyberKeyParameters privParams)
	{
	}

	public byte[] ExtractSecret(byte[] encapsulation)
	{
		return null;
	}
}
