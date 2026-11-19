using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Cms;

public class KekRecipientInformation : RecipientInformation
{
	private KekRecipientInfo info;

	internal KekRecipientInformation(KekRecipientInfo info, CmsSecureReadable secureReadable)
		: base(null, null)
	{
	}

	public override CmsTypedStream GetContentStream(ICipherParameters key)
	{
		return null;
	}
}
