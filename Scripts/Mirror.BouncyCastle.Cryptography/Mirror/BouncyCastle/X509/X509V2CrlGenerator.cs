using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.X509;

public class X509V2CrlGenerator
{
	private readonly X509ExtensionsGenerator extGenerator;

	private V2TbsCertListGenerator tbsGen;

	public IEnumerable<string> SignatureAlgNames => null;

	public X509V2CrlGenerator()
	{
	}

	public X509V2CrlGenerator(X509Crl template)
	{
	}

	public X509V2CrlGenerator(CertificateList template)
	{
	}

	public void Reset()
	{
	}

	public void SetIssuerDN(X509Name issuer)
	{
	}

	public void SetThisUpdate(DateTime date)
	{
	}

	public void SetNextUpdate(DateTime date)
	{
	}

	public void AddCrlEntry(BigInteger userCertificate, DateTime revocationDate, int reason)
	{
	}

	public void AddCrlEntry(BigInteger userCertificate, DateTime revocationDate, int reason, DateTime invalidityDate)
	{
	}

	public void AddCrlEntry(BigInteger userCertificate, DateTime revocationDate, X509Extensions extensions)
	{
	}

	public void AddCrl(X509Crl other)
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

	public X509Crl Generate(ISignatureFactory signatureFactory)
	{
		return null;
	}

	public X509Crl Generate(ISignatureFactory signatureFactory, bool isCritical, ISignatureFactory altSignatureFactory)
	{
		return null;
	}
}
