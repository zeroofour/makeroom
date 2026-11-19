using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Saber;

public abstract class SaberKeyParameters : AsymmetricKeyParameter
{
	private readonly SaberParameters m_parameters;

	public SaberParameters Parameters => null;

	internal SaberKeyParameters(bool isPrivate, SaberParameters parameters)
		: base(privateKey: false)
	{
	}
}
