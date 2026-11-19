using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Cms;

public class CmsEnvelopedData
{
	internal RecipientInformationStore recipientInfoStore;

	internal ContentInfo contentInfo;

	private AlgorithmIdentifier encAlg;

	private Asn1Set unprotectedAttributes;

	public AlgorithmIdentifier EncryptionAlgorithmID => null;

	public string EncryptionAlgOid => null;

	public ContentInfo ContentInfo => null;

	public CmsEnvelopedData(byte[] envelopedData)
	{
	}

	public CmsEnvelopedData(Stream envelopedData)
	{
	}

	public CmsEnvelopedData(ContentInfo contentInfo)
	{
	}

	public RecipientInformationStore GetRecipientInfos()
	{
		return null;
	}

	public Mirror.BouncyCastle.Asn1.Cms.AttributeTable GetUnprotectedAttributes()
	{
		return null;
	}

	public byte[] GetEncoded()
	{
		return null;
	}
}
