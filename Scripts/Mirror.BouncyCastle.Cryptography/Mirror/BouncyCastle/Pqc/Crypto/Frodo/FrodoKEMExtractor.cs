using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Frodo;

public class FrodoKEMExtractor : IEncapsulatedSecretExtractor
{
	private readonly FrodoKeyParameters m_key;

	private readonly FrodoEngine m_engine;

	public int EncapsulationLength => 0;

	public FrodoKEMExtractor(FrodoKeyParameters privParams)
	{
	}

	public byte[] ExtractSecret(byte[] encapsulation)
	{
		return null;
	}
}
