using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Ocsp;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Ocsp;

public class OcspReqGenerator
{
	private class RequestObject
	{
		internal CertificateID certId;

		internal X509Extensions extensions;

		public RequestObject(CertificateID certId, X509Extensions extensions)
		{
		}

		public Request ToRequest()
		{
			return null;
		}
	}

	private List<RequestObject> list;

	private GeneralName requestorName;

	private X509Extensions requestExtensions;

	public IEnumerable<string> SignatureAlgNames => null;

	public void AddRequest(CertificateID certId)
	{
	}

	public void AddRequest(CertificateID certId, X509Extensions singleRequestExtensions)
	{
	}

	public void SetRequestorName(X509Name requestorName)
	{
	}

	public void SetRequestorName(GeneralName requestorName)
	{
	}

	public void SetRequestExtensions(X509Extensions requestExtensions)
	{
	}

	private OcspReq GenerateRequest(DerObjectIdentifier signingAlgorithm, AsymmetricKeyParameter privateKey, X509Certificate[] chain, SecureRandom random)
	{
		return null;
	}

	public OcspReq Generate()
	{
		return null;
	}

	public OcspReq Generate(string signingAlgorithm, AsymmetricKeyParameter privateKey, X509Certificate[] chain)
	{
		return null;
	}

	public OcspReq Generate(string signingAlgorithm, AsymmetricKeyParameter privateKey, X509Certificate[] chain, SecureRandom random)
	{
		return null;
	}
}
