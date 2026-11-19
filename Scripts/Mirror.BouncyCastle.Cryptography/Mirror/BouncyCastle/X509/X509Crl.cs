using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Security.Certificates;

namespace Mirror.BouncyCastle.X509;

public class X509Crl : X509ExtensionBase
{
	private class CachedEncoding
	{
		private readonly byte[] encoding;

		private readonly CrlException exception;

		internal byte[] Encoding => null;

		internal CachedEncoding(byte[] encoding, CrlException exception)
		{
		}

		internal byte[] GetEncoded()
		{
			return null;
		}
	}

	private readonly CertificateList c;

	private readonly byte[] sigAlgParams;

	private readonly bool isIndirect;

	private string m_sigAlgName;

	private CachedEncoding cachedEncoding;

	private bool hashValueSet;

	private int hashValue;

	public virtual CertificateList CertificateList => null;

	public virtual int Version => 0;

	public virtual X509Name IssuerDN => null;

	public virtual DateTime ThisUpdate => default;

	public virtual DateTime? NextUpdate => null;

	public virtual string SigAlgName => null;

	public virtual string SigAlgOid => null;

	public virtual AlgorithmIdentifier SignatureAlgorithm => null;

	protected virtual bool IsIndirectCrl => false;

	public X509Crl(byte[] encoding)
	{
	}

	public X509Crl(CertificateList c)
	{
	}

	protected override X509Extensions GetX509Extensions()
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

	public virtual void Verify(AsymmetricKeyParameter publicKey)
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

	private ISet<X509CrlEntry> LoadCrlEntries()
	{
		return null;
	}

	public virtual X509CrlEntry GetRevokedCertificate(BigInteger serialNumber)
	{
		return null;
	}

	public virtual ISet<X509CrlEntry> GetRevokedCertificates()
	{
		return null;
	}

	public virtual byte[] GetTbsCertList()
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

	public virtual bool IsRevoked(X509Certificate cert)
	{
		return false;
	}

	private CachedEncoding GetCachedEncoding()
	{
		return null;
	}

	private static CachedEncoding CreateCachedEncoding(CertificateList c)
	{
		return null;
	}
}
