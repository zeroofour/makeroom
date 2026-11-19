using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Bike;

public abstract class BikeKeyParameters : AsymmetricKeyParameter
{
	private readonly BikeParameters m_parameters;

	public BikeParameters Parameters => null;

	internal BikeKeyParameters(bool isPrivate, BikeParameters parameters)
		: base(privateKey: false)
	{
	}
}
