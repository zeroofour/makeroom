using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Security;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cms;

public class KeyTransRecipientInfoGenerator : RecipientInfoGenerator
{
	private readonly IKeyWrapper m_keyWrapper;

	private IssuerAndSerialNumber m_issuerAndSerialNumber;

	private Asn1OctetString m_subjectKeyIdentifier;

	protected virtual AlgorithmIdentifier AlgorithmDetails => null;

	public KeyTransRecipientInfoGenerator(X509Certificate recipCert, IKeyWrapper keyWrapper)
	{
	}

	public KeyTransRecipientInfoGenerator(IssuerAndSerialNumber issuerAndSerial, IKeyWrapper keyWrapper)
	{
	}

	public KeyTransRecipientInfoGenerator(byte[] subjectKeyID, IKeyWrapper keyWrapper)
	{
	}

	public RecipientInfo Generate(KeyParameter contentEncryptionKey, SecureRandom random)
	{
		return null;
	}

	protected virtual byte[] GenerateWrappedKey(KeyParameter contentEncryptionKey)
	{
		return null;
	}
}
