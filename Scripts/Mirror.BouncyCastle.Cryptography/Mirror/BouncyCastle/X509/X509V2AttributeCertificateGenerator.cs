using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.X509;

public class X509V2AttributeCertificateGenerator
{
	private readonly X509ExtensionsGenerator extGenerator;

	private V2AttributeCertificateInfoGenerator acInfoGen;

	public IEnumerable<string> SignatureAlgNames => null;

	public void Reset()
	{
	}

	public void SetHolder(AttributeCertificateHolder holder)
	{
	}

	public void SetIssuer(AttributeCertificateIssuer issuer)
	{
	}

	public void SetSerialNumber(BigInteger serialNumber)
	{
	}

	public void SetNotBefore(DateTime date)
	{
	}

	public void SetNotAfter(DateTime date)
	{
	}

	public void AddAttribute(X509Attribute attribute)
	{
	}

	public void SetIssuerUniqueId(bool[] iui)
	{
	}

	public void AddExtension(string oid, bool critical, Asn1Encodable extensionValue)
	{
	}

	public void AddExtension(string oid, bool critical, byte[] extensionValue)
	{
	}

	public X509V2AttributeCertificate Generate(ISignatureFactory signatureFactory)
	{
		return null;
	}
}
