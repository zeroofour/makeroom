namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcX448 : TlsAgreement
{
	protected readonly BcTlsCrypto m_crypto;

	protected readonly byte[] m_privateKey;

	protected readonly byte[] m_peerPublicKey;

	public BcX448(BcTlsCrypto crypto)
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
