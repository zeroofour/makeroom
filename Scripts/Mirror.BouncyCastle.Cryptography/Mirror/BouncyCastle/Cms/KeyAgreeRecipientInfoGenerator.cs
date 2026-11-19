using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Security;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cms;

internal class KeyAgreeRecipientInfoGenerator : RecipientInfoGenerator
{
	private readonly List<KeyAgreeRecipientIdentifier> m_recipientIDs;

	private readonly List<AsymmetricKeyParameter> m_recipientKeys;

	private DerObjectIdentifier m_keyAgreementOid;

	private DerObjectIdentifier m_keyEncryptionOid;

	private AsymmetricCipherKeyPair m_senderKeyPair;

	internal DerObjectIdentifier KeyAgreementOid
	{
		set
		{
		}
	}

	internal DerObjectIdentifier KeyEncryptionOid
	{
		set
		{
		}
	}

	internal AsymmetricCipherKeyPair SenderKeyPair
	{
		set
		{
		}
	}

	internal KeyAgreeRecipientInfoGenerator(IEnumerable<X509Certificate> recipientCerts)
	{
	}

	internal KeyAgreeRecipientInfoGenerator(byte[] subjectKeyID, AsymmetricKeyParameter publicKey)
	{
	}

	public RecipientInfo Generate(KeyParameter contentEncryptionKey, SecureRandom random)
	{
		return null;
	}

	private static OriginatorPublicKey CreateOriginatorPublicKey(AsymmetricKeyParameter publicKey)
	{
		return null;
	}

	private static OriginatorPublicKey CreateOriginatorPublicKey(SubjectPublicKeyInfo originatorKeyInfo)
	{
		return null;
	}
}
