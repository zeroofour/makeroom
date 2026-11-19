using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Falcon;

public abstract class FalconKeyParameters : AsymmetricKeyParameter
{
	private readonly FalconParameters m_parameters;

	public FalconParameters Parameters => null;

	internal FalconKeyParameters(bool isprivate, FalconParameters parameters)
		: base(privateKey: false)
	{
	}
}
