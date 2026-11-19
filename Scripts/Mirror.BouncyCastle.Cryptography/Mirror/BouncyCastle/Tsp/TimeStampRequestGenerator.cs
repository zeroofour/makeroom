using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Tsp;

public class TimeStampRequestGenerator
{
	private DerObjectIdentifier reqPolicy;

	private DerBoolean certReq;

	private Dictionary<DerObjectIdentifier, X509Extension> m_extensions;

	private List<DerObjectIdentifier> m_ordering;

	public void SetReqPolicy(string reqPolicy)
	{
	}

	public void SetCertReq(bool certReq)
	{
	}

	public virtual void AddExtension(DerObjectIdentifier oid, bool critical, Asn1Encodable extValue)
	{
	}

	public virtual void AddExtension(DerObjectIdentifier oid, bool critical, byte[] extValue)
	{
	}

	public TimeStampRequest Generate(string digestAlgorithm, byte[] digest)
	{
		return null;
	}

	public TimeStampRequest Generate(string digestAlgorithmOid, byte[] digest, BigInteger nonce)
	{
		return null;
	}

	public virtual TimeStampRequest Generate(DerObjectIdentifier digestAlgorithm, byte[] digest)
	{
		return null;
	}

	public virtual TimeStampRequest Generate(DerObjectIdentifier digestAlgorithm, byte[] digest, BigInteger nonce)
	{
		return null;
	}
}
