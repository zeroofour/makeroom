using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.X509;

public class X509V3CertificateGenerator
{
	private readonly X509ExtensionsGenerator extGenerator;

	private V3TbsCertificateGenerator tbsGen;

	public IEnumerable<string> SignatureAlgNames => null;

	public X509V3CertificateGenerator()
	{
	}

	public X509V3CertificateGenerator(X509Certificate template)
	{
	}

	public X509V3CertificateGenerator(X509CertificateStructure template)
	{
	}

	public void Reset()
	{
	}

	public void SetSerialNumber(BigInteger serialNumber)
	{
	}

	public void SetIssuerDN(X509Name issuer)
	{
	}

	public void SetNotBefore(DateTime date)
	{
	}

	public void SetNotAfter(DateTime date)
	{
	}

	public void SetSubjectDN(X509Name subject)
	{
	}

	public void SetPublicKey(AsymmetricKeyParameter publicKey)
	{
	}

	public void SetSubjectPublicKeyInfo(SubjectPublicKeyInfo subjectPublicKeyInfo)
	{
	}

	public void SetSubjectUniqueID(bool[] uniqueID)
	{
	}

	public void SetIssuerUniqueID(bool[] uniqueID)
	{
	}

	public void AddExtension(string oid, bool critical, Asn1Encodable extensionValue)
	{
	}

	public void AddExtension(DerObjectIdentifier oid, bool critical, Asn1Encodable extensionValue)
	{
	}

	public void AddExtension(string oid, bool critical, byte[] extensionValue)
	{
	}

	public void AddExtension(DerObjectIdentifier oid, bool critical, byte[] extensionValue)
	{
	}

	public void CopyAndAddExtension(string oid, bool critical, X509Certificate cert)
	{
	}

	public void CopyAndAddExtension(DerObjectIdentifier oid, bool critical, X509Certificate cert)
	{
	}

	public X509Certificate Generate(ISignatureFactory signatureFactory)
	{
		return null;
	}

	public X509Certificate Generate(ISignatureFactory signatureFactory, bool isCritical, ISignatureFactory altSignatureFactory)
	{
		return null;
	}

	internal static DerBitString BooleanToBitString(bool[] id)
	{
		return null;
	}
}
