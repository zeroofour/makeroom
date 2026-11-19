using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math.EC;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsECDomain : TlsECDomain
{
	protected readonly BcTlsCrypto m_crypto;

	protected readonly TlsECConfig m_config;

	protected readonly ECDomainParameters m_domainParameters;

	public static BcTlsSecret CalculateECDHAgreement(BcTlsCrypto crypto, ECPrivateKeyParameters privateKey, ECPublicKeyParameters publicKey)
	{
		return null;
	}

	public static ECDomainParameters GetDomainParameters(TlsECConfig ecConfig)
	{
		return null;
	}

	public static ECDomainParameters GetDomainParameters(int namedGroup)
	{
		return null;
	}

	public BcTlsECDomain(BcTlsCrypto crypto, TlsECConfig ecConfig)
	{
	}

	public virtual BcTlsSecret CalculateECDHAgreement(ECPrivateKeyParameters privateKey, ECPublicKeyParameters publicKey)
	{
		return null;
	}

	public virtual TlsAgreement CreateECDH()
	{
		return null;
	}

	public virtual ECPoint DecodePoint(byte[] encoding)
	{
		return null;
	}

	public virtual ECPublicKeyParameters DecodePublicKey(byte[] encoding)
	{
		return null;
	}

	public virtual byte[] EncodePoint(ECPoint point)
	{
		return null;
	}

	public virtual byte[] EncodePublicKey(ECPublicKeyParameters publicKey)
	{
		return null;
	}

	public virtual AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}
}
