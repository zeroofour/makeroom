using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Operators.Utilities;

public class DefaultDigestAlgorithmFinder : IDigestAlgorithmFinder
{
	public static readonly DefaultDigestAlgorithmFinder Instance;

	private static readonly Dictionary<DerObjectIdentifier, DerObjectIdentifier> DigestOids;

	private static readonly Dictionary<string, DerObjectIdentifier> DigestNameToOids;

	private static readonly Dictionary<DerObjectIdentifier, AlgorithmIdentifier> DigestOidToAlgIDs;

	private static readonly HashSet<DerObjectIdentifier> Shake256Oids;

	static DefaultDigestAlgorithmFinder()
	{
	}

	private static void AddDigestAlgID(DerObjectIdentifier oid, bool withNullParams)
	{
	}

	protected DefaultDigestAlgorithmFinder()
	{
	}

	public virtual AlgorithmIdentifier Find(AlgorithmIdentifier signatureAlgorithm)
	{
		return null;
	}

	public virtual AlgorithmIdentifier Find(DerObjectIdentifier digestOid)
	{
		return null;
	}

	public virtual AlgorithmIdentifier Find(string digestName)
	{
		return null;
	}
}
