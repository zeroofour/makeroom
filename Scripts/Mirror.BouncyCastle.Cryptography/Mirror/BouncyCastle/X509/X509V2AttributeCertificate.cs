using System;
using System.IO;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.X509;

public class X509V2AttributeCertificate : X509ExtensionBase
{
	private readonly AttributeCertificate cert;

	private readonly DateTime notBefore;

	private readonly DateTime notAfter;

	public virtual AttributeCertificate AttributeCertificate => null;

	public virtual int Version => 0;

	public virtual BigInteger SerialNumber => null;

	public virtual AttributeCertificateHolder Holder => null;

	public virtual AttributeCertificateIssuer Issuer => null;

	public virtual DateTime NotBefore => default;

	public virtual DateTime NotAfter => default;

	public virtual bool IsValidNow => false;

	public virtual AlgorithmIdentifier SignatureAlgorithm => null;

	private static AttributeCertificate GetObject(Stream input)
	{
		return null;
	}

	public X509V2AttributeCertificate(Stream encIn)
	{
	}

	public X509V2AttributeCertificate(byte[] encoded)
	{
	}

	public X509V2AttributeCertificate(AttributeCertificate cert)
	{
	}

	public virtual bool[] GetIssuerUniqueID()
	{
		return null;
	}

	public virtual bool IsValid(DateTime date)
	{
		return false;
	}

	public virtual void CheckValidity()
	{
	}

	public virtual void CheckValidity(DateTime date)
	{
	}

	public virtual byte[] GetSignature()
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

	public virtual void Verify(AsymmetricKeyParameter key)
	{
	}

	public virtual void Verify(IVerifierFactoryProvider verifierProvider)
	{
	}

	protected virtual void CheckSignature(IVerifierFactory verifier)
	{
	}

	protected virtual bool CheckSignatureValid(IVerifierFactory verifier)
	{
		return false;
	}

	public virtual byte[] GetEncoded()
	{
		return null;
	}

	protected override X509Extensions GetX509Extensions()
	{
		return null;
	}

	public virtual X509Attribute[] GetAttributes()
	{
		return null;
	}

	public virtual X509Attribute[] GetAttributes(string oid)
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
