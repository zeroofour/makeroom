using Mirror.BouncyCastle.Asn1.Pkcs;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Cms;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Crmf;

public class PkiArchiveControlBuilder
{
	private readonly CmsEnvelopedDataGenerator m_envGen;

	private readonly CmsProcessableByteArray m_keyContent;

	public PkiArchiveControlBuilder(PrivateKeyInfo privateKeyInfo, GeneralName generalName)
	{
	}

	public PkiArchiveControlBuilder AddRecipientGenerator(RecipientInfoGenerator recipientGen)
	{
		return null;
	}

	public PkiArchiveControl Build(ICipherBuilderWithKey contentEncryptor)
	{
		return null;
	}
}
