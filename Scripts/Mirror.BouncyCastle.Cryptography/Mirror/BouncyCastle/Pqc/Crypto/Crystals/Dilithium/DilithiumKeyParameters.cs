using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;

public abstract class DilithiumKeyParameters : AsymmetricKeyParameter
{
	private readonly DilithiumParameters m_parameters;

	public DilithiumParameters Parameters => null;

	internal DilithiumKeyParameters(bool isPrivate, DilithiumParameters parameters)
		: base(privateKey: false)
	{
	}
}
