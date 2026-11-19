using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsDHDomain : TlsDHDomain
{
	protected readonly BcTlsCrypto m_crypto;

	protected readonly TlsDHConfig m_config;

	protected readonly DHParameters m_domainParameters;

	private static byte[] EncodeValue(DHParameters dh, bool padded, BigInteger x)
	{
		return null;
	}

	private static int GetValueLength(DHParameters dh)
	{
		return 0;
	}

	public static BcTlsSecret CalculateDHAgreement(BcTlsCrypto crypto, DHPrivateKeyParameters privateKey, DHPublicKeyParameters publicKey, bool padded)
	{
		return null;
	}

	public static DHParameters GetDomainParameters(TlsDHConfig dhConfig)
	{
		return null;
	}

	public BcTlsDHDomain(BcTlsCrypto crypto, TlsDHConfig dhConfig)
	{
	}

	public virtual BcTlsSecret CalculateDHAgreement(DHPrivateKeyParameters privateKey, DHPublicKeyParameters publicKey)
	{
		return null;
	}

	public virtual TlsAgreement CreateDH()
	{
		return null;
	}

	public virtual BigInteger DecodeParameter(byte[] encoding)
	{
		return null;
	}

	public virtual DHPublicKeyParameters DecodePublicKey(byte[] encoding)
	{
		return null;
	}

	public virtual byte[] EncodeParameter(BigInteger x)
	{
		return null;
	}

	public virtual byte[] EncodePublicKey(DHPublicKeyParameters publicKey)
	{
		return null;
	}

	public virtual AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}
}
