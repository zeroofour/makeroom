using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Picnic;

public abstract class PicnicKeyParameters : AsymmetricKeyParameter
{
	private readonly PicnicParameters m_parameters;

	public PicnicParameters Parameters => null;

	internal PicnicKeyParameters(bool isPrivate, PicnicParameters parameters)
		: base(privateKey: false)
	{
	}
}
