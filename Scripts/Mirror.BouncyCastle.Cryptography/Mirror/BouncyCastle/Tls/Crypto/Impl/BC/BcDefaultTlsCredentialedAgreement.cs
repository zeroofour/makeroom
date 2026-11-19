using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcDefaultTlsCredentialedAgreement : TlsCredentialedAgreement, TlsCredentials
{
	private sealed class DHCredentialedAgreement : TlsCredentialedAgreement, TlsCredentials
	{
		private readonly BcTlsCrypto m_crypto;

		private readonly Certificate m_certificate;

		private readonly DHPrivateKeyParameters m_privateKey;

		public Certificate Certificate => null;

		internal DHCredentialedAgreement(BcTlsCrypto crypto, Certificate certificate, DHPrivateKeyParameters privateKey)
		{
		}

		public TlsSecret GenerateAgreement(TlsCertificate peerCertificate)
		{
			return null;
		}
	}

	private sealed class ECCredentialedAgreement : TlsCredentialedAgreement, TlsCredentials
	{
		private readonly BcTlsCrypto m_crypto;

		private readonly Certificate m_certificate;

		private readonly ECPrivateKeyParameters m_privateKey;

		public Certificate Certificate => null;

		internal ECCredentialedAgreement(BcTlsCrypto crypto, Certificate certificate, ECPrivateKeyParameters privateKey)
		{
		}

		public TlsSecret GenerateAgreement(TlsCertificate peerCertificate)
		{
			return null;
		}
	}

	protected readonly TlsCredentialedAgreement m_agreementCredentials;

	public virtual Certificate Certificate => null;

	public BcDefaultTlsCredentialedAgreement(BcTlsCrypto crypto, Certificate certificate, AsymmetricKeyParameter privateKey)
	{
	}

	public virtual TlsSecret GenerateAgreement(TlsCertificate peerCertificate)
	{
		return null;
	}
}
