using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cms;

public class SignerInfoGeneratorBuilder
{
	private bool directSignature;

	private CmsAttributeTableGenerator signedGen;

	private CmsAttributeTableGenerator unsignedGen;

	public SignerInfoGeneratorBuilder SetDirectSignature(bool hasNoSignedAttributes)
	{
		return null;
	}

	public SignerInfoGeneratorBuilder WithSignedAttributeGenerator(CmsAttributeTableGenerator signedGen)
	{
		return null;
	}

	public SignerInfoGeneratorBuilder WithUnsignedAttributeGenerator(CmsAttributeTableGenerator unsignedGen)
	{
		return null;
	}

	public SignerInfoGenerator Build(ISignatureFactory contentSigner, X509Certificate certificate)
	{
		return null;
	}

	public SignerInfoGenerator Build(ISignatureFactory signerFactory, byte[] subjectKeyIdentifier)
	{
		return null;
	}

	private SignerInfoGenerator CreateGenerator(ISignatureFactory contentSigner, SignerIdentifier sigId)
	{
		return null;
	}
}
