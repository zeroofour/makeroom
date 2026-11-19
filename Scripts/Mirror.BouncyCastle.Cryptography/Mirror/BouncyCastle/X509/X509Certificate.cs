using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Security.Certificates;

namespace Mirror.BouncyCastle.X509;

public class X509Certificate : X509ExtensionBase
{
	private class CachedEncoding
	{
		private readonly byte[] encoding;

		private readonly CertificateEncodingException exception;

		internal byte[] Encoding => null;

		internal CachedEncoding(byte[] encoding, CertificateEncodingException exception)
		{
		}

		internal byte[] GetEncoded()
		{
			return null;
		}
	}

	private readonly X509CertificateStructure c;

	private readonly byte[] sigAlgParams;

	private readonly BasicConstraints basicConstraints;

	private readonly bool[] keyUsage;

	private string m_sigAlgName;

	private AsymmetricKeyParameter publicKeyValue;

	private CachedEncoding cachedEncoding;

	private bool hashValueSet;

	private int hashValue;

	public virtual X509CertificateStructure CertificateStructure => null;

	public virtual bool IsValidNow => false;

	public virtual int Version => 0;

	public virtual BigInteger SerialNumber => null;

	public virtual X509Name IssuerDN => null;

	public virtual X509Name SubjectDN => null;

	public virtual DateTime NotBefore => default;

	public virtual DateTime NotAfter => default;

	public virtual TbsCertificateStructure TbsCertificate => null;

	public virtual string SigAlgName => null;

	public virtual string SigAlgOid => null;

	public virtual AlgorithmIdentifier SignatureAlgorithm => null;

	public virtual DerBitString IssuerUniqueID => null;

	public virtual DerBitString SubjectUniqueID => null;

	public virtual SubjectPublicKeyInfo SubjectPublicKeyInfo => null;

	protected X509Certificate()
	{
	}

	public X509Certificate(byte[] certData)
	{
	}

	public X509Certificate(X509CertificateStructure c)
	{
	}

	public virtual bool IsValid(DateTime time)
	{
		return false;
	}

	public virtual void CheckValidity()
	{
	}

	public virtual void CheckValidity(DateTime time)
	{
	}

	public virtual byte[] GetTbsCertificate()
	{
		return null;
	}

	public virtual byte[] GetSignature()
	{
		return null;
	}

	public virtual byte[] GetSigAlgParams()
	{
		return null;
	}

	public virtual bool[] GetKeyUsage()
	{
		return null;
	}

	public virtual IList<DerObjectIdentifier> GetExtendedKeyUsage()
	{
		return null;
	}

	public virtual int GetBasicConstraints()
	{
		return 0;
	}

	public virtual GeneralNames GetIssuerAlternativeNameExtension()
	{
		return null;
	}

	public virtual GeneralNames GetSubjectAlternativeNameExtension()
	{
		return null;
	}

	public virtual IList<IList<object>> GetIssuerAlternativeNames()
	{
		return null;
	}

	public virtual IList<IList<object>> GetSubjectAlternativeNames()
	{
		return null;
	}

	protected virtual GeneralNames GetAlternativeNameExtension(DerObjectIdentifier oid)
	{
		return null;
	}

	protected virtual IList<IList<object>> GetAlternativeNames(DerObjectIdentifier oid)
	{
		return null;
	}

	protected override X509Extensions GetX509Extensions()
	{
		return null;
	}

	public virtual AsymmetricKeyParameter GetPublicKey()
	{
		return null;
	}

	public virtual byte[] GetEncoded()
	{
		return null;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public virtual bool IsSignatureValid(AsymmetricKeyParameter key)
	{
		return false;
	}

	public virtual bool IsSignatureValid(IVerifierFactoryProvider verifierProvider)
	{
		return false;
	}

	public virtual bool IsAlternativeSignatureValid(IVerifierFactoryProvider verifierProvider)
	{
		return false;
	}

	public virtual void Verify(AsymmetricKeyParameter key)
	{
	}

	public virtual void Verify(IVerifierFactoryProvider verifierProvider)
	{
	}

	public virtual void VerifyAltSignature(IVerifierFactoryProvider verifierProvider)
	{
	}

	protected virtual void CheckSignature(IVerifierFactory verifier)
	{
	}

	protected virtual bool CheckSignatureValid(IVerifierFactory verifier)
	{
		return false;
	}

	private CachedEncoding GetCachedEncoding()
	{
		return null;
	}

	private static CachedEncoding CreateCachedEncoding(X509CertificateStructure c)
	{
		return null;
	}

	private static AsymmetricKeyParameter CreatePublicKey(X509CertificateStructure c)
	{
		return null;
	}
}
