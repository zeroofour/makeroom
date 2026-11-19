using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cms;

public class SignerInfoGenerator
{
	internal X509Certificate certificate;

	internal ISignatureFactory contentSigner;

	internal SignerIdentifier sigId;

	internal CmsAttributeTableGenerator signedGen;

	internal CmsAttributeTableGenerator unsignedGen;

	private bool isDirectSignature;

	internal SignerInfoGenerator(SignerIdentifier sigId, ISignatureFactory signerFactory)
	{
	}

	internal SignerInfoGenerator(SignerIdentifier sigId, ISignatureFactory signerFactory, bool isDirectSignature)
	{
	}

	internal SignerInfoGenerator(SignerIdentifier sigId, ISignatureFactory contentSigner, CmsAttributeTableGenerator signedGen, CmsAttributeTableGenerator unsignedGen)
	{
	}

	internal void SetAssociatedCertificate(X509Certificate certificate)
	{
	}

	public SignerInfoGeneratorBuilder NewBuilder()
	{
		return null;
	}
}
