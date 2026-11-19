using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Cms;

internal class KekRecipientInfoGenerator : RecipientInfoGenerator
{
	private KeyParameter keyEncryptionKey;

	private string keyEncryptionKeyOID;

	private KekIdentifier kekIdentifier;

	private AlgorithmIdentifier keyEncryptionAlgorithm;

	internal KekIdentifier KekIdentifier
	{
		set
		{
		}
	}

	internal KeyParameter KeyEncryptionKey
	{
		set
		{
		}
	}

	internal string KeyEncryptionKeyOID
	{
		set
		{
		}
	}

	internal KekRecipientInfoGenerator()
	{
	}

	public RecipientInfo Generate(KeyParameter contentEncryptionKey, SecureRandom random)
	{
		return null;
	}

	private static AlgorithmIdentifier DetermineKeyEncAlg(string algorithm, KeyParameter key)
	{
		return null;
	}
}
