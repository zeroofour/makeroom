using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X9;

namespace Mirror.BouncyCastle.Crypto.Utilities;

public static class SshNamedCurves
{
	private static readonly Dictionary<string, DerObjectIdentifier> objIds;

	private static readonly Dictionary<DerObjectIdentifier, string> names;

	public static IEnumerable<string> Names => null;

	private static void DefineCurveAlias(string name, DerObjectIdentifier oid)
	{
	}

	private static X9ECParametersHolder FindByOidLazy(DerObjectIdentifier oid)
	{
		return null;
	}

	static SshNamedCurves()
	{
	}

	public static X9ECParameters GetByName(string name)
	{
		return null;
	}

	public static X9ECParametersHolder GetByNameLazy(string name)
	{
		return null;
	}

	public static X9ECParameters GetByOid(DerObjectIdentifier oid)
	{
		return null;
	}

	public static X9ECParametersHolder GetByOidLazy(DerObjectIdentifier oid)
	{
		return null;
	}

	public static string GetName(DerObjectIdentifier oid)
	{
		return null;
	}

	public static DerObjectIdentifier GetOid(string name)
	{
		return null;
	}
}
