using System;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Operators.Utilities;

namespace Mirror.BouncyCastle.Cms;

[Obsolete("Use 'Mirror.BouncyCastle.Operators.Utilities.DefaultDigestAlgorithmFinder' instead")]
public class DefaultDigestAlgorithmIdentifierFinder : IDigestAlgorithmFinder
{
	public AlgorithmIdentifier Find(AlgorithmIdentifier sigAlgId)
	{
		return null;
	}

	public virtual AlgorithmIdentifier Find(DerObjectIdentifier digAlgOid)
	{
		return null;
	}

	public AlgorithmIdentifier Find(string digAlgName)
	{
		return null;
	}
}
