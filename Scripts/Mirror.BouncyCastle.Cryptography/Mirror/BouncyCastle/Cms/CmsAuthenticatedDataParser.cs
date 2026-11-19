using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Cms;

public class CmsAuthenticatedDataParser : CmsContentInfoParser
{
	internal RecipientInformationStore _recipientInfoStore;

	internal AuthenticatedDataParser authData;

	private AlgorithmIdentifier macAlg;

	private byte[] mac;

	private Mirror.BouncyCastle.Asn1.Cms.AttributeTable authAttrs;

	private Mirror.BouncyCastle.Asn1.Cms.AttributeTable unauthAttrs;

	private bool authAttrNotRead;

	private bool unauthAttrNotRead;

	public AlgorithmIdentifier MacAlgorithmID => null;

	public string MacAlgOid => null;

	public Asn1Object MacAlgParams => null;

	public CmsAuthenticatedDataParser(byte[] envelopedData)
		: base(null)
	{
	}

	public CmsAuthenticatedDataParser(Stream envelopedData)
		: base(null)
	{
	}

	public RecipientInformationStore GetRecipientInfos()
	{
		return null;
	}

	public byte[] GetMac()
	{
		return null;
	}

	public Mirror.BouncyCastle.Asn1.Cms.AttributeTable GetAuthAttrs()
	{
		return null;
	}

	public Mirror.BouncyCastle.Asn1.Cms.AttributeTable GetUnauthAttrs()
	{
		return null;
	}
}
