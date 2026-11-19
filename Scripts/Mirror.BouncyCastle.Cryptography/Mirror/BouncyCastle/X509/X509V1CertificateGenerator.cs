using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.X509;

public class X509V1CertificateGenerator
{
	private V1TbsCertificateGenerator tbsGen;

	public IEnumerable<string> SignatureAlgNames => null;

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

	public X509Certificate Generate(ISignatureFactory signatureFactory)
	{
		return null;
	}
}
