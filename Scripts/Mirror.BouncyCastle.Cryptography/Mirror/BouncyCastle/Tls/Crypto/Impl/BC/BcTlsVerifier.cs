using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public abstract class BcTlsVerifier : TlsVerifier
{
	protected readonly BcTlsCrypto m_crypto;

	protected readonly AsymmetricKeyParameter m_publicKey;

	protected BcTlsVerifier(BcTlsCrypto crypto, AsymmetricKeyParameter publicKey)
	{
	}

	public virtual TlsStreamVerifier GetStreamVerifier(DigitallySigned digitallySigned)
	{
		return null;
	}

	public virtual bool VerifyRawSignature(DigitallySigned digitallySigned, byte[] hash)
	{
		return false;
	}
}
