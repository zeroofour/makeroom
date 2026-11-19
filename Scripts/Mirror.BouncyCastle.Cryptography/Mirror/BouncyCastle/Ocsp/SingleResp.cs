using System;
using Mirror.BouncyCastle.Asn1.Ocsp;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Ocsp;

public class SingleResp : X509ExtensionBase
{
	internal readonly SingleResponse resp;

	public DateTime ThisUpdate => default;

	public DateTime? NextUpdate => null;

	public X509Extensions SingleExtensions => null;

	public SingleResp(SingleResponse resp)
	{
	}

	public CertificateID GetCertID()
	{
		return null;
	}

	public object GetCertStatus()
	{
		return null;
	}

	protected override X509Extensions GetX509Extensions()
	{
		return null;
	}
}
