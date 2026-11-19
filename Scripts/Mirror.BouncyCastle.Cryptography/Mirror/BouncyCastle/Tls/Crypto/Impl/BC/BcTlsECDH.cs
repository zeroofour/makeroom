using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsECDH : TlsAgreement
{
	protected readonly BcTlsECDomain m_domain;

	protected AsymmetricCipherKeyPair m_localKeyPair;

	protected ECPublicKeyParameters m_peerPublicKey;

	public BcTlsECDH(BcTlsECDomain domain)
	{
	}

	public virtual byte[] GenerateEphemeral()
	{
		return null;
	}

	public virtual void ReceivePeerValue(byte[] peerValue)
	{
	}

	public virtual TlsSecret CalculateSecret()
	{
		return null;
	}
}
