using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcDefaultTlsCredentialedDecryptor : TlsCredentialedDecryptor, TlsCredentials
{
	protected readonly BcTlsCrypto m_crypto;

	protected readonly Certificate m_certificate;

	protected readonly AsymmetricKeyParameter m_privateKey;

	public virtual Certificate Certificate => null;

	public BcDefaultTlsCredentialedDecryptor(BcTlsCrypto crypto, Certificate certificate, AsymmetricKeyParameter privateKey)
	{
	}

	public virtual TlsSecret Decrypt(TlsCryptoParameters cryptoParams, byte[] ciphertext)
	{
		return null;
	}

	protected virtual TlsSecret SafeDecryptPreMasterSecret(TlsCryptoParameters cryptoParams, RsaKeyParameters rsaServerPrivateKey, byte[] encryptedPreMasterSecret)
	{
		return null;
	}
}
