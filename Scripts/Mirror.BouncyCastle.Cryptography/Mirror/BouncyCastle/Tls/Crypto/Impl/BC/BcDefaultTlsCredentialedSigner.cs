using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcDefaultTlsCredentialedSigner : DefaultTlsCredentialedSigner
{
	private static BcTlsCertificate GetEndEntity(BcTlsCrypto crypto, Certificate certificate)
	{
		return null;
	}

	private static TlsSigner MakeSigner(BcTlsCrypto crypto, AsymmetricKeyParameter privateKey, Certificate certificate, SignatureAndHashAlgorithm signatureAndHashAlgorithm)
	{
		return null;
	}

	public BcDefaultTlsCredentialedSigner(TlsCryptoParameters cryptoParams, BcTlsCrypto crypto, AsymmetricKeyParameter privateKey, Certificate certificate, SignatureAndHashAlgorithm signatureAndHashAlgorithm)
		: base(null, null, null, null)
	{
	}
}
