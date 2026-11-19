using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Cms;

public class PasswordRecipientInformation : RecipientInformation
{
	private readonly PasswordRecipientInfo info;

	public virtual AlgorithmIdentifier KeyDerivationAlgorithm => null;

	internal PasswordRecipientInformation(PasswordRecipientInfo info, CmsSecureReadable secureReadable)
		: base(null, null)
	{
	}

	public override CmsTypedStream GetContentStream(ICipherParameters key)
	{
		return null;
	}
}
