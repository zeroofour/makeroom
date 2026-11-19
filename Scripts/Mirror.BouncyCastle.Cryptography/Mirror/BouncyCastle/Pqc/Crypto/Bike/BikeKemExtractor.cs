using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Bike;

public sealed class BikeKemExtractor : IEncapsulatedSecretExtractor
{
	private readonly BikeKeyParameters key;

	public int EncapsulationLength => 0;

	public BikeKemExtractor(BikePrivateKeyParameters privParams)
	{
	}

	public byte[] ExtractSecret(byte[] encapsulation)
	{
		return null;
	}
}
