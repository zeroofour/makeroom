using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Crypto.Agreement;

public sealed class X448Agreement : IRawAgreement
{
	private X448PrivateKeyParameters m_privateKey;

	public int AgreementSize => 0;

	public void Init(ICipherParameters parameters)
	{
	}

	public void CalculateAgreement(ICipherParameters publicKey, byte[] buf, int off)
	{
	}
}
