using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Ntru;

public abstract class NtruKeyParameters : AsymmetricKeyParameter
{
	private readonly NtruParameters m_parameters;

	public NtruParameters Parameters => null;

	internal NtruKeyParameters(bool privateKey, NtruParameters parameters)
		: base(privateKey: false)
	{
	}

	public abstract byte[] GetEncoded();
}
