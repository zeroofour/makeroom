using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Ocsp;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Utilities.Collections;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Ocsp;

public class OcspReq : X509ExtensionBase
{
	private OcspRequest req;

	public int Version => 0;

	public GeneralName RequestorName => null;

	public X509Extensions RequestExtensions => null;

	public string SignatureAlgOid => null;

	public bool IsSigned => false;

	public OcspReq(OcspRequest req)
	{
	}

	public OcspReq(byte[] req)
	{
	}

	public OcspReq(Stream inStr)
	{
	}

	private OcspReq(Asn1InputStream aIn)
	{
	}

	public byte[] GetTbsRequest()
	{
		return null;
	}

	public Req[] GetRequestList()
	{
		return null;
	}

	protected override X509Extensions GetX509Extensions()
	{
		return null;
	}

	public byte[] GetSignature()
	{
		return null;
	}

	private List<X509Certificate> GetCertList()
	{
		return null;
	}

	public X509Certificate[] GetCerts()
	{
		return null;
	}

	public IStore<X509Certificate> GetCertificates()
	{
		return null;
	}

	public bool Verify(AsymmetricKeyParameter publicKey)
	{
		return false;
	}

	public byte[] GetEncoded()
	{
		return null;
	}
}
