using System.Collections.Generic;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Modes;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsCrypto : AbstractTlsCrypto
{
	private readonly SecureRandom m_entropySource;

	public override SecureRandom SecureRandom => null;

	public BcTlsCrypto()
	{
	}

	public BcTlsCrypto(SecureRandom entropySource)
	{
	}

	internal virtual BcTlsSecret AdoptLocalSecret(byte[] data)
	{
		return null;
	}

	public override TlsCertificate CreateCertificate(short type, byte[] encoding)
	{
		return null;
	}

	public override TlsCipher CreateCipher(TlsCryptoParameters cryptoParams, int encryptionAlgorithm, int macAlgorithm)
	{
		return null;
	}

	public override TlsDHDomain CreateDHDomain(TlsDHConfig dhConfig)
	{
		return null;
	}

	public override TlsECDomain CreateECDomain(TlsECConfig ecConfig)
	{
		return null;
	}

	public override TlsNonceGenerator CreateNonceGenerator(byte[] additionalSeedMaterial)
	{
		return null;
	}

	public override bool HasAnyStreamVerifiers(IList<SignatureAndHashAlgorithm> signatureAndHashAlgorithms)
	{
		return false;
	}

	public override bool HasAnyStreamVerifiersLegacy(short[] clientCertificateTypes)
	{
		return false;
	}

	public override bool HasCryptoHashAlgorithm(int cryptoHashAlgorithm)
	{
		return false;
	}

	public override bool HasCryptoSignatureAlgorithm(int cryptoSignatureAlgorithm)
	{
		return false;
	}

	public override bool HasDHAgreement()
	{
		return false;
	}

	public override bool HasECDHAgreement()
	{
		return false;
	}

	public override bool HasEncryptionAlgorithm(int encryptionAlgorithm)
	{
		return false;
	}

	public override bool HasHkdfAlgorithm(int cryptoHashAlgorithm)
	{
		return false;
	}

	public override bool HasMacAlgorithm(int macAlgorithm)
	{
		return false;
	}

	public override bool HasNamedGroup(int namedGroup)
	{
		return false;
	}

	public override bool HasRsaEncryption()
	{
		return false;
	}

	public override bool HasSignatureAlgorithm(short signatureAlgorithm)
	{
		return false;
	}

	public override bool HasSignatureAndHashAlgorithm(SignatureAndHashAlgorithm sigAndHashAlgorithm)
	{
		return false;
	}

	public override bool HasSignatureScheme(int signatureScheme)
	{
		return false;
	}

	public override bool HasSrpAuthentication()
	{
		return false;
	}

	public override TlsSecret CreateSecret(byte[] data)
	{
		return null;
	}

	public override TlsSecret GenerateRsaPreMasterSecret(ProtocolVersion version)
	{
		return null;
	}

	public virtual IDigest CloneDigest(int cryptoHashAlgorithm, IDigest digest)
	{
		return null;
	}

	public virtual IDigest CreateDigest(int cryptoHashAlgorithm)
	{
		return null;
	}

	public override TlsHash CreateHash(int cryptoHashAlgorithm)
	{
		return null;
	}

	protected virtual IBlockCipher CreateBlockCipher(int encryptionAlgorithm)
	{
		return null;
	}

	protected virtual IBlockCipher CreateCbcBlockCipher(IBlockCipher blockCipher)
	{
		return null;
	}

	protected virtual IBlockCipher CreateCbcBlockCipher(int encryptionAlgorithm)
	{
		return null;
	}

	protected virtual TlsCipher CreateChaCha20Poly1305(TlsCryptoParameters cryptoParams)
	{
		return null;
	}

	protected virtual TlsAeadCipher CreateCipher_Aes_Ccm(TlsCryptoParameters cryptoParams, int cipherKeySize, int macSize)
	{
		return null;
	}

	protected virtual TlsAeadCipher CreateCipher_Aes_Gcm(TlsCryptoParameters cryptoParams, int cipherKeySize, int macSize)
	{
		return null;
	}

	protected virtual TlsAeadCipher CreateCipher_Aria_Gcm(TlsCryptoParameters cryptoParams, int cipherKeySize, int macSize)
	{
		return null;
	}

	protected virtual TlsAeadCipher CreateCipher_Camellia_Gcm(TlsCryptoParameters cryptoParams, int cipherKeySize, int macSize)
	{
		return null;
	}

	protected virtual TlsCipher CreateCipher_Cbc(TlsCryptoParameters cryptoParams, int encryptionAlgorithm, int cipherKeySize, int macAlgorithm)
	{
		return null;
	}

	protected virtual TlsAeadCipher CreateCipher_SM4_Ccm(TlsCryptoParameters cryptoParams)
	{
		return null;
	}

	protected virtual TlsAeadCipher CreateCipher_SM4_Gcm(TlsCryptoParameters cryptoParams)
	{
		return null;
	}

	protected virtual TlsNullCipher CreateNullCipher(TlsCryptoParameters cryptoParams, int macAlgorithm)
	{
		return null;
	}

	protected virtual IBlockCipher CreateAesEngine()
	{
		return null;
	}

	protected virtual IBlockCipher CreateAriaEngine()
	{
		return null;
	}

	protected virtual IBlockCipher CreateCamelliaEngine()
	{
		return null;
	}

	protected virtual IBlockCipher CreateDesEdeEngine()
	{
		return null;
	}

	protected virtual IBlockCipher CreateSeedEngine()
	{
		return null;
	}

	protected virtual IBlockCipher CreateSM4Engine()
	{
		return null;
	}

	protected virtual CcmBlockCipher CreateCcmMode(IBlockCipher engine)
	{
		return null;
	}

	protected virtual IAeadCipher CreateGcmMode(IBlockCipher engine)
	{
		return null;
	}

	protected virtual CcmBlockCipher CreateAeadCipher_Aes_Ccm()
	{
		return null;
	}

	protected virtual IAeadCipher CreateAeadCipher_Aes_Gcm()
	{
		return null;
	}

	protected virtual IAeadCipher CreateAeadCipher_Aria_Gcm()
	{
		return null;
	}

	protected virtual IAeadCipher CreateAeadCipher_Camellia_Gcm()
	{
		return null;
	}

	protected virtual CcmBlockCipher CreateAeadCipher_SM4_Ccm()
	{
		return null;
	}

	protected virtual IAeadCipher CreateAeadCipher_SM4_Gcm()
	{
		return null;
	}

	public override TlsHmac CreateHmac(int macAlgorithm)
	{
		return null;
	}

	public override TlsHmac CreateHmacForHash(int cryptoHashAlgorithm)
	{
		return null;
	}

	protected virtual TlsHmac CreateHmac_Ssl(int macAlgorithm)
	{
		return null;
	}

	protected virtual TlsHmac CreateMac(TlsCryptoParameters cryptoParams, int macAlgorithm)
	{
		return null;
	}

	public override TlsSrp6Client CreateSrp6Client(TlsSrpConfig srpConfig)
	{
		return null;
	}

	public override TlsSrp6Server CreateSrp6Server(TlsSrpConfig srpConfig, BigInteger srpVerifier)
	{
		return null;
	}

	public override TlsSrp6VerifierGenerator CreateSrp6VerifierGenerator(TlsSrpConfig srpConfig)
	{
		return null;
	}

	public override TlsSecret HkdfInit(int cryptoHashAlgorithm)
	{
		return null;
	}
}
