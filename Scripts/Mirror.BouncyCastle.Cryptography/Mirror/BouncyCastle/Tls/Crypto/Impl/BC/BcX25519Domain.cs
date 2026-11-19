namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcX25519Domain : TlsECDomain
{
	protected readonly BcTlsCrypto m_crypto;

	public BcX25519Domain(BcTlsCrypto crypto)
	{
	}

	public virtual TlsAgreement CreateECDH()
	{
		return null;
	}
}
