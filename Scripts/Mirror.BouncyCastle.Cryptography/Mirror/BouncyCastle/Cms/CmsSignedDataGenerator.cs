using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cms;

public class CmsSignedDataGenerator : CmsSignedGenerator
{
	private class SignerInf
	{
		private readonly CmsSignedGenerator outer;

		private readonly ISignatureFactory sigCalc;

		private readonly SignerIdentifier signerIdentifier;

		private readonly DerObjectIdentifier m_digestOid;

		private readonly DerObjectIdentifier m_encOid;

		private readonly CmsAttributeTableGenerator sAttr;

		private readonly CmsAttributeTableGenerator unsAttr;

		private readonly Mirror.BouncyCastle.Asn1.Cms.AttributeTable baseSignedTable;

		internal AlgorithmIdentifier DigestAlgorithmID => null;

		internal CmsAttributeTableGenerator SignedAttributes => null;

		internal CmsAttributeTableGenerator UnsignedAttributes => null;

		internal SignerInf(CmsSignedGenerator outer, AsymmetricKeyParameter key, SecureRandom random, SignerIdentifier signerIdentifier, DerObjectIdentifier digestOid, DerObjectIdentifier encOid, CmsAttributeTableGenerator sAttr, CmsAttributeTableGenerator unsAttr, Mirror.BouncyCastle.Asn1.Cms.AttributeTable baseSignedTable)
		{
		}

		internal SignerInf(CmsSignedGenerator outer, ISignatureFactory sigCalc, SignerIdentifier signerIdentifier, CmsAttributeTableGenerator sAttr, CmsAttributeTableGenerator unsAttr, Mirror.BouncyCastle.Asn1.Cms.AttributeTable baseSignedTable)
		{
		}

		internal SignerInfo ToSignerInfo(DerObjectIdentifier contentType, CmsProcessable content)
		{
			return null;
		}
	}

	private readonly IList<SignerInf> signerInfs;

	public CmsSignedDataGenerator()
	{
	}

	public CmsSignedDataGenerator(SecureRandom random)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string digestOID)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string encryptionOID, string digestOID)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string digestOID)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string encryptionOID, string digestOID)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string digestOID, Mirror.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, Mirror.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string encryptionOID, string digestOID, Mirror.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, Mirror.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string digestOID, Mirror.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, Mirror.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string encryptionOID, string digestOID, Mirror.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, Mirror.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string digestOID, CmsAttributeTableGenerator signedAttrGen, CmsAttributeTableGenerator unsignedAttrGen)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string encryptionOID, string digestOID, CmsAttributeTableGenerator signedAttrGen, CmsAttributeTableGenerator unsignedAttrGen)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string digestOID, CmsAttributeTableGenerator signedAttrGen, CmsAttributeTableGenerator unsignedAttrGen)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string encryptionOID, string digestOID, CmsAttributeTableGenerator signedAttrGen, CmsAttributeTableGenerator unsignedAttrGen)
	{
	}

	public void AddSignerInfoGenerator(SignerInfoGenerator signerInfoGenerator)
	{
	}

	private void DoAddSigner(AsymmetricKeyParameter privateKey, SignerIdentifier signerIdentifier, DerObjectIdentifier encryptionOid, DerObjectIdentifier digestOid, CmsAttributeTableGenerator signedAttrGen, CmsAttributeTableGenerator unsignedAttrGen, Mirror.BouncyCastle.Asn1.Cms.AttributeTable baseSignedTable)
	{
	}

	public CmsSignedData Generate(CmsProcessable content)
	{
		return null;
	}

	public CmsSignedData Generate(string signedContentType, CmsProcessable content, bool encapsulate)
	{
		return null;
	}

	public CmsSignedData Generate(CmsProcessable content, bool encapsulate)
	{
		return null;
	}

	public SignerInformationStore GenerateCounterSigners(SignerInformation signer)
	{
		return null;
	}
}
