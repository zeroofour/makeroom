using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.NtruPrime;

public abstract class NtruLPRimeKeyParameters : AsymmetricKeyParameter
{
	private readonly NtruLPRimeParameters m_primeParameters;

	public NtruLPRimeParameters Parameters => null;

	internal NtruLPRimeKeyParameters(bool isPrivate, NtruLPRimeParameters primeParameters)
		: base(privateKey: false)
	{
	}
}
