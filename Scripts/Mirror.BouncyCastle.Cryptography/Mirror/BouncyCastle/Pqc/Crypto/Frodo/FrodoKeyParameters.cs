using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Frodo;

public abstract class FrodoKeyParameters : AsymmetricKeyParameter
{
	private readonly FrodoParameters m_parameters;

	public FrodoParameters Parameters => null;

	internal FrodoKeyParameters(bool isPrivate, FrodoParameters parameters)
		: base(privateKey: false)
	{
	}
}
