using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public abstract class BcTlsSigner : TlsSigner
{
	protected readonly BcTlsCrypto m_crypto;

	protected readonly AsymmetricKeyParameter m_privateKey;

	protected BcTlsSigner(BcTlsCrypto crypto, AsymmetricKeyParameter privateKey)
	{
	}

	public virtual byte[] GenerateRawSignature(SignatureAndHashAlgorithm algorithm, byte[] hash)
	{
		return null;
	}

	public virtual TlsStreamSigner GetStreamSigner(SignatureAndHashAlgorithm algorithm)
	{
		return null;
	}
}
