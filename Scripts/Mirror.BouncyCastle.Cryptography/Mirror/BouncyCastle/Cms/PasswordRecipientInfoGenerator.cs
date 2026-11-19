using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Cms;

internal class PasswordRecipientInfoGenerator : RecipientInfoGenerator
{
	private AlgorithmIdentifier keyDerivationAlgorithm;

	private KeyParameter keyEncryptionKey;

	private string keyEncryptionKeyOID;

	internal AlgorithmIdentifier KeyDerivationAlgorithm
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

	internal PasswordRecipientInfoGenerator()
	{
	}

	public RecipientInfo Generate(KeyParameter contentEncryptionKey, SecureRandom random)
	{
		return null;
	}
}
