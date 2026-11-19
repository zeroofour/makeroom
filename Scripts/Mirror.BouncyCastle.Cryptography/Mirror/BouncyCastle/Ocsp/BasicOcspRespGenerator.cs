using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Ocsp;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Ocsp;

public class BasicOcspRespGenerator
{
	private class ResponseObject
	{
		internal CertificateID certId;

		internal CertStatus certStatus;

		internal DerGeneralizedTime thisUpdate;

		internal DerGeneralizedTime nextUpdate;

		internal X509Extensions extensions;

		internal ResponseObject(CertificateID certId, CertificateStatus certStatus, DateTime thisUpdate, DateTime? nextUpdate, X509Extensions extensions)
		{
		}

		public SingleResponse ToResponse()
		{
			return null;
		}
	}

	private readonly List<ResponseObject> list;

	private X509Extensions responseExtensions;

	private RespID responderID;

	public IEnumerable<string> SignatureAlgNames => null;

	public BasicOcspRespGenerator(RespID responderID)
	{
	}

	public BasicOcspRespGenerator(AsymmetricKeyParameter publicKey)
	{
	}

	public void AddResponse(CertificateID certID, CertificateStatus certStatus)
	{
	}

	public void AddResponse(CertificateID certID, CertificateStatus certStatus, X509Extensions singleExtensions)
	{
	}

	public void AddResponse(CertificateID certID, CertificateStatus certStatus, DateTime? nextUpdate, X509Extensions singleExtensions)
	{
	}

	public void AddResponse(CertificateID certID, CertificateStatus certStatus, DateTime thisUpdate, DateTime? nextUpdate, X509Extensions singleExtensions)
	{
	}

	public void SetResponseExtensions(X509Extensions responseExtensions)
	{
	}

	private BasicOcspResp GenerateResponse(ISignatureFactory signatureFactory, X509Certificate[] chain, DateTime producedAt)
	{
		return null;
	}

	public BasicOcspResp Generate(string signingAlgorithm, AsymmetricKeyParameter privateKey, X509Certificate[] chain, DateTime thisUpdate)
	{
		return null;
	}

	public BasicOcspResp Generate(string signingAlgorithm, AsymmetricKeyParameter privateKey, X509Certificate[] chain, DateTime producedAt, SecureRandom random)
	{
		return null;
	}

	public BasicOcspResp Generate(ISignatureFactory signatureCalculatorFactory, X509Certificate[] chain, DateTime producedAt)
	{
		return null;
	}
}
