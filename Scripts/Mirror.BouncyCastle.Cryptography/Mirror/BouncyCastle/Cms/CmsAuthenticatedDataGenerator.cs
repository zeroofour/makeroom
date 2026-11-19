using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Cms;

public class CmsAuthenticatedDataGenerator : CmsAuthenticatedGenerator
{
	public CmsAuthenticatedDataGenerator()
	{
	}

	public CmsAuthenticatedDataGenerator(SecureRandom random)
	{
	}

	private CmsAuthenticatedData Generate(CmsProcessable content, string macOid, CipherKeyGenerator keyGen)
	{
		return null;
	}

	public CmsAuthenticatedData Generate(CmsProcessable content, string encryptionOid)
	{
		return null;
	}
}
