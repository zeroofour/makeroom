using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class DefaultTlsCredentialedSigner : TlsCredentialedSigner, TlsCredentials
{
	protected readonly TlsCryptoParameters m_cryptoParams;

	protected readonly Certificate m_certificate;

	protected readonly SignatureAndHashAlgorithm m_signatureAndHashAlgorithm;

	protected readonly TlsSigner m_signer;

	public virtual Certificate Certificate => null;

	public virtual SignatureAndHashAlgorithm SignatureAndHashAlgorithm => null;

	public DefaultTlsCredentialedSigner(TlsCryptoParameters cryptoParams, TlsSigner signer, Certificate certificate, SignatureAndHashAlgorithm signatureAndHashAlgorithm)
	{
	}

	public virtual byte[] GenerateRawSignature(byte[] hash)
	{
		return null;
	}

	public virtual TlsStreamSigner GetStreamSigner()
	{
		return null;
	}

	protected virtual SignatureAndHashAlgorithm GetEffectiveAlgorithm()
	{
		return null;
	}
}
