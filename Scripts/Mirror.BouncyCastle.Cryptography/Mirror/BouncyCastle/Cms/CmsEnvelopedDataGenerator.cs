using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Cms;

public class CmsEnvelopedDataGenerator : CmsEnvelopedGenerator
{
	public CmsEnvelopedDataGenerator()
	{
	}

	public CmsEnvelopedDataGenerator(SecureRandom random)
	{
	}

	private CmsEnvelopedData Generate(CmsProcessable content, string encryptionOid, CipherKeyGenerator keyGen)
	{
		return null;
	}

	public CmsEnvelopedData Generate(CmsProcessable content, string encryptionOid)
	{
		return null;
	}

	public CmsEnvelopedData Generate(CmsProcessable content, ICipherBuilderWithKey cipherBuilder)
	{
		return null;
	}

	public CmsEnvelopedData Generate(CmsProcessable content, string encryptionOid, int keySize)
	{
		return null;
	}
}
