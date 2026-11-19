using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Cms;

public class CmsEnvelopedDataParser : CmsContentInfoParser
{
	internal RecipientInformationStore recipientInfoStore;

	internal EnvelopedDataParser envelopedData;

	private AlgorithmIdentifier _encAlg;

	private Mirror.BouncyCastle.Asn1.Cms.AttributeTable _unprotectedAttributes;

	private bool _attrNotRead;

	public AlgorithmIdentifier EncryptionAlgorithmID => null;

	public string EncryptionAlgOid => null;

	public Asn1Object EncryptionAlgParams => null;

	public CmsEnvelopedDataParser(byte[] envelopedData)
		: base(null)
	{
	}

	public CmsEnvelopedDataParser(Stream envelopedData)
		: base(null)
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
}
