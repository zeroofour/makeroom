using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Crypto.Agreement;

public sealed class X25519Agreement : IRawAgreement
{
	private X25519PrivateKeyParameters m_privateKey;

	public int AgreementSize => 0;

	public void Init(ICipherParameters parameters)
	{
	}

	public void CalculateAgreement(ICipherParameters publicKey, byte[] buf, int off)
	{
	}
}
