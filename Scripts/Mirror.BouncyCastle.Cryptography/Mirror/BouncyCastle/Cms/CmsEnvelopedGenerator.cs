using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Security;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cms;

public abstract class CmsEnvelopedGenerator
{
	internal static readonly short[] rc2Table;

	public static readonly string DesCbc;

	public static readonly string DesEde3Cbc;

	public static readonly string RC2Cbc;

	public const string IdeaCbc = "1.3.6.1.4.1.188.7.1.1.2";

	public const string Cast5Cbc = "1.2.840.113533.7.66.10";

	public static readonly string Aes128Cbc;

	public static readonly string Aes192Cbc;

	public static readonly string Aes256Cbc;

	public static readonly string Aes128Ccm;

	public static readonly string Aes192Ccm;

	public static readonly string Aes256Ccm;

	public static readonly string Aes128Gcm;

	public static readonly string Aes192Gcm;

	public static readonly string Aes256Gcm;

	public static readonly string Camellia128Cbc;

	public static readonly string Camellia192Cbc;

	public static readonly string Camellia256Cbc;

	public static readonly string SeedCbc;

	public static readonly string DesEde3Wrap;

	public static readonly string Aes128Wrap;

	public static readonly string Aes192Wrap;

	public static readonly string Aes256Wrap;

	public static readonly string Camellia128Wrap;

	public static readonly string Camellia192Wrap;

	public static readonly string Camellia256Wrap;

	public static readonly string SeedWrap;

	public static readonly string Gost28147Wrap;

	public static readonly string Gost28147CryptoProWrap;

	public static readonly string ECDHSha1Kdf;

	public static readonly string ECCDHSha1Kdf;

	public static readonly string ECMqvSha1Kdf;

	public static readonly string ECDHSha224Kdf;

	public static readonly string ECCDHSha224Kdf;

	public static readonly string ECMqvSha224Kdf;

	public static readonly string ECDHSha256Kdf;

	public static readonly string ECCDHSha256Kdf;

	public static readonly string ECMqvSha256Kdf;

	public static readonly string ECDHSha384Kdf;

	public static readonly string ECCDHSha384Kdf;

	public static readonly string ECMqvSha384Kdf;

	public static readonly string ECDHSha512Kdf;

	public static readonly string ECCDHSha512Kdf;

	public static readonly string ECMqvSha512Kdf;

	internal readonly IList<RecipientInfoGenerator> recipientInfoGenerators;

	internal readonly SecureRandom m_random;

	internal CmsAttributeTableGenerator unprotectedAttributeGenerator;

	public CmsAttributeTableGenerator UnprotectedAttributeGenerator
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected CmsEnvelopedGenerator()
	{
	}

	protected CmsEnvelopedGenerator(SecureRandom random)
	{
	}

	public void AddKeyTransRecipient(X509Certificate cert)
	{
	}

	public void AddKeyTransRecipient(string algorithm, X509Certificate cert)
	{
	}

	public void AddKeyTransRecipient(AsymmetricKeyParameter pubKey, byte[] subKeyId)
	{
	}

	public void AddKeyTransRecipient(string algorithm, AsymmetricKeyParameter pubKey, byte[] subKeyId)
	{
	}

	public void AddKekRecipient(string keyAlgorithm, KeyParameter key, byte[] keyIdentifier)
	{
	}

	public void AddKekRecipient(string keyAlgorithm, KeyParameter key, KekIdentifier kekIdentifier)
	{
	}

	public void AddPasswordRecipient(CmsPbeKey pbeKey, string kekAlgorithmOid)
	{
	}

	public void AddKeyAgreementRecipient(string agreementAlgorithm, AsymmetricKeyParameter senderPrivateKey, AsymmetricKeyParameter senderPublicKey, X509Certificate recipientCert, string cekWrapAlgorithm)
	{
	}

	public void AddKeyAgreementRecipients(string agreementAlgorithm, AsymmetricKeyParameter senderPrivateKey, AsymmetricKeyParameter senderPublicKey, IEnumerable<X509Certificate> recipientCerts, string cekWrapAlgorithm)
	{
	}

	public void AddKeyAgreementRecipient(string agreementAlgorithm, AsymmetricKeyParameter senderPrivateKey, AsymmetricKeyParameter senderPublicKey, byte[] recipientKeyID, AsymmetricKeyParameter recipientPublicKey, string cekWrapAlgorithm)
	{
	}

	public void AddRecipientInfoGenerator(RecipientInfoGenerator recipientInfoGenerator)
	{
	}

	protected internal virtual AlgorithmIdentifier GetAlgorithmIdentifier(string encryptionOid, KeyParameter encKey, Asn1Encodable asn1Params, out ICipherParameters cipherParameters)
	{
		cipherParameters = null;
		return null;
	}

	protected internal virtual Asn1Encodable GenerateAsn1Parameters(string encryptionOid, byte[] encKeyBytes)
	{
		return null;
	}
}
