using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Hqc;

public abstract class HqcKeyParameters : AsymmetricKeyParameter
{
	private readonly HqcParameters m_parameters;

	public HqcParameters Parameters => null;

	internal HqcKeyParameters(bool isPrivate, HqcParameters parameters)
		: base(privateKey: false)
	{
	}
}
