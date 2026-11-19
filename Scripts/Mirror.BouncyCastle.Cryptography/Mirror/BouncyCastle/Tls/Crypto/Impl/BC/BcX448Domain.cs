namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcX448Domain : TlsECDomain
{
	protected readonly BcTlsCrypto m_crypto;

	public BcX448Domain(BcTlsCrypto crypto)
	{
	}

	public virtual TlsAgreement CreateECDH()
	{
		return null;
	}
}
