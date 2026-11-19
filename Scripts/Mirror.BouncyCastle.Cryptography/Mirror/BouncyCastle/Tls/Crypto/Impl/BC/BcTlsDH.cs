using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsDH : TlsAgreement
{
	protected readonly BcTlsDHDomain m_domain;

	protected AsymmetricCipherKeyPair m_localKeyPair;

	protected DHPublicKeyParameters m_peerPublicKey;

	public BcTlsDH(BcTlsDHDomain domain)
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
