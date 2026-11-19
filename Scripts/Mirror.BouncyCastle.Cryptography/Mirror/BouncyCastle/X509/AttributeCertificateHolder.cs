using System;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Utilities.Collections;

namespace Mirror.BouncyCastle.X509;

public class AttributeCertificateHolder : IEquatable<AttributeCertificateHolder>, ISelector<X509Certificate>, ICloneable
{
	internal readonly Holder m_holder;

	public int DigestedObjectType => 0;

	public string DigestAlgorithm => null;

	public string OtherObjectTypeID => null;

	public BigInteger SerialNumber => null;

	internal AttributeCertificateHolder(Asn1Sequence seq)
	{
	}

	public AttributeCertificateHolder(X509Name issuerName, BigInteger serialNumber)
	{
	}

	public AttributeCertificateHolder(X509Certificate cert)
	{
	}

	public AttributeCertificateHolder(X509Name principal)
	{
	}

	public AttributeCertificateHolder(int digestedObjectType, string digestAlgorithm, string otherObjectTypeID, byte[] objectDigest)
	{
	}

	public byte[] GetObjectDigest()
	{
		return null;
	}

	private GeneralNames GenerateGeneralNames(X509Name principal)
	{
		return null;
	}

	private bool MatchesDN(X509Name subject, GeneralNames targets)
	{
		return false;
	}

	private X509Name[] GetPrincipals(GeneralNames generalNames)
	{
		return null;
	}

	public X509Name[] GetEntityNames()
	{
		return null;
	}

	public X509Name[] GetIssuer()
	{
		return null;
	}

	public object Clone()
	{
		return null;
	}

	public bool Match(X509Certificate x509Cert)
	{
		return false;
	}

	public virtual bool Equals(AttributeCertificateHolder other)
	{
		return false;
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
