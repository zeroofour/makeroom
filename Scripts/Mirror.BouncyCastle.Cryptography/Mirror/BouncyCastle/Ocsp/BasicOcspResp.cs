using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1.Ocsp;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Utilities.Collections;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Ocsp;

public class BasicOcspResp : X509ExtensionBase
{
	private readonly BasicOcspResponse resp;

	private readonly ResponseData data;

	public int Version => 0;

	public RespID ResponderId => null;

	public DateTime ProducedAt => default;

	public SingleResp[] Responses => null;

	public X509Extensions ResponseExtensions => null;

	public string SignatureAlgName => null;

	public string SignatureAlgOid => null;

	public BasicOcspResp(BasicOcspResponse resp)
	{
	}

	public byte[] GetTbsResponseData()
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

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
