using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

public abstract class SphincsPlusKeyParameters : AsymmetricKeyParameter
{
	private readonly SphincsPlusParameters m_parameters;

	public SphincsPlusParameters Parameters => null;

	internal SphincsPlusKeyParameters(bool isPrivate, SphincsPlusParameters parameters)
		: base(privateKey: false)
	{
	}
}
