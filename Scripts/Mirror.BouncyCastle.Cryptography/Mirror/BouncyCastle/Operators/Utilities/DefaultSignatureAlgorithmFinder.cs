using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Pkcs;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Operators.Utilities;

public class DefaultSignatureAlgorithmFinder : ISignatureAlgorithmFinder
{
	public static readonly DefaultSignatureAlgorithmFinder Instance;

	private static readonly Dictionary<string, DerObjectIdentifier> Algorithms;

	private static readonly HashSet<DerObjectIdentifier> NoParams;

	private static readonly Dictionary<string, Asn1Encodable> Parameters;

	private static readonly HashSet<DerObjectIdentifier> Pkcs15RsaEncryption;

	private static readonly Dictionary<DerObjectIdentifier, DerObjectIdentifier> DigestOids;

	static DefaultSignatureAlgorithmFinder()
	{
	}

	private static RsassaPssParameters CreatePssParams(AlgorithmIdentifier hashAlgID, int saltSize)
	{
		return null;
	}

	protected DefaultSignatureAlgorithmFinder()
	{
	}

	public virtual AlgorithmIdentifier Find(string signatureName)
	{
		return null;
	}
}
