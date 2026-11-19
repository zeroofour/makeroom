using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Bike;

public sealed class BikeKeyGenerationParameters : KeyGenerationParameters
{
	private readonly BikeParameters m_parameters;

	public BikeParameters Parameters => null;

	public BikeKeyGenerationParameters(SecureRandom random, BikeParameters parameters)
		: base(null, 0)
	{
	}
}
