using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsRawKeyCertificate : TlsCertificate
{
	protected readonly BcTlsCrypto m_crypto;

	protected readonly SubjectPublicKeyInfo m_keyInfo;

	protected DHPublicKeyParameters m_pubKeyDH;

	protected ECPublicKeyParameters m_pubKeyEC;

	protected Ed25519PublicKeyParameters m_pubKeyEd25519;

	protected Ed448PublicKeyParameters m_pubKeyEd448;

	protected RsaKeyParameters m_pubKeyRsa;

	public virtual SubjectPublicKeyInfo SubjectPublicKeyInfo => null;

	public virtual BigInteger SerialNumber => null;

	public virtual string SigAlgOid => null;

	public BcTlsRawKeyCertificate(BcTlsCrypto crypto, byte[] encoding)
	{
	}

	public BcTlsRawKeyCertificate(BcTlsCrypto crypto, SubjectPublicKeyInfo keyInfo)
	{
	}

	public virtual TlsEncryptor CreateEncryptor(int tlsCertificateRole)
	{
		return null;
	}

	public virtual TlsVerifier CreateVerifier(short signatureAlgorithm)
	{
		return null;
	}

	public virtual Tls13Verifier CreateVerifier(int signatureScheme)
	{
		return null;
	}

	public virtual byte[] GetEncoded()
	{
		return null;
	}

	public virtual byte[] GetExtension(DerObjectIdentifier extensionOid)
	{
		return null;
	}

	public virtual Asn1Encodable GetSigAlgParams()
	{
		return null;
	}

	public virtual short GetLegacySignatureAlgorithm()
	{
		return 0;
	}

	public virtual DHPublicKeyParameters GetPubKeyDH()
	{
		return null;
	}

	public virtual DsaPublicKeyParameters GetPubKeyDss()
	{
		return null;
	}

	public virtual ECPublicKeyParameters GetPubKeyEC()
	{
		return null;
	}

	public virtual Ed25519PublicKeyParameters GetPubKeyEd25519()
	{
		return null;
	}

	public virtual Ed448PublicKeyParameters GetPubKeyEd448()
	{
		return null;
	}

	public virtual RsaKeyParameters GetPubKeyRsa()
	{
		return null;
	}

	public virtual bool SupportsSignatureAlgorithm(short signatureAlgorithm)
	{
		return false;
	}

	public virtual bool SupportsSignatureAlgorithmCA(short signatureAlgorithm)
	{
		return false;
	}

	public virtual TlsCertificate CheckUsageInRole(int tlsCertificateRole)
	{
		return null;
	}

	protected virtual AsymmetricKeyParameter GetPublicKey()
	{
		return null;
	}

	protected virtual bool SupportsKeyUsage(int keyUsageBits)
	{
		return false;
	}

	protected virtual bool SupportsRsa_Pkcs1()
	{
		return false;
	}

	protected virtual bool SupportsRsa_Pss_Pss(short signatureAlgorithm)
	{
		return false;
	}

	protected virtual bool SupportsRsa_Pss_Rsae()
	{
		return false;
	}

	protected virtual bool SupportsSignatureAlgorithm(short signatureAlgorithm, int keyUsage)
	{
		return false;
	}

	public virtual void ValidateKeyUsage(int keyUsageBits)
	{
	}

	protected virtual void ValidateRsa_Pkcs1()
	{
	}

	protected virtual void ValidateRsa_Pss_Pss(short signatureAlgorithm)
	{
	}

	protected virtual void ValidateRsa_Pss_Rsae()
	{
	}
}
