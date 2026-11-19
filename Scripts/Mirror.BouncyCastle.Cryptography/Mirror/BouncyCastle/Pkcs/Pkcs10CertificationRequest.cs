using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Pkcs;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pkcs;

public class Pkcs10CertificationRequest : CertificationRequest
{
	internal static readonly Dictionary<string, DerObjectIdentifier> m_algorithms;

	internal static readonly Dictionary<string, Asn1Encodable> m_exParams;

	internal static readonly Dictionary<DerObjectIdentifier, string> m_keyAlgorithms;

	internal static readonly HashSet<DerObjectIdentifier> m_noParams;

	static Pkcs10CertificationRequest()
	{
	}

	private static RsassaPssParameters CreatePssParams(AlgorithmIdentifier hashAlgId, int saltSize)
	{
		return null;
	}

	protected Pkcs10CertificationRequest()
	{
	}

	public Pkcs10CertificationRequest(byte[] encoded)
	{
	}

	public Pkcs10CertificationRequest(Asn1Sequence seq)
	{
	}

	public Pkcs10CertificationRequest(Stream input)
	{
	}

	public Pkcs10CertificationRequest(string signatureAlgorithm, X509Name subject, AsymmetricKeyParameter publicKey, Asn1Set attributes, AsymmetricKeyParameter signingKey)
	{
	}

	public Pkcs10CertificationRequest(ISignatureFactory signatureFactory, X509Name subject, AsymmetricKeyParameter publicKey, Asn1Set attributes)
	{
	}

	private void Init(ISignatureFactory signatureFactory, X509Name subject, AsymmetricKeyParameter publicKey, Asn1Set attributes)
	{
	}

	public AsymmetricKeyParameter GetPublicKey()
	{
		return null;
	}

	public bool Verify()
	{
		return false;
	}

	public bool Verify(AsymmetricKeyParameter publicKey)
	{
		return false;
	}

	public bool Verify(IVerifierFactoryProvider verifierProvider)
	{
		return false;
	}

	public bool Verify(IVerifierFactory verifier)
	{
		return false;
	}

	private void SetSignatureParameters(ISigner signature, Asn1Encodable asn1Params)
	{
	}

	internal static string GetSignatureName(AlgorithmIdentifier sigAlgId)
	{
		return null;
	}

	private static string GetDigestAlgName(DerObjectIdentifier digestAlgOID)
	{
		return null;
	}

	public X509Extensions GetRequestedExtensions()
	{
		return null;
	}
}
