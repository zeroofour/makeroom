using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1.CryptoPro;

public static class Gost3410NamedParameters
{
	private static readonly Gost3410ParamSetParameters cryptoProA;

	private static readonly Gost3410ParamSetParameters cryptoProB;

	private static readonly Gost3410ParamSetParameters cryptoProXchA;

	private static readonly Dictionary<string, DerObjectIdentifier> objIds;

	private static readonly Dictionary<DerObjectIdentifier, Gost3410ParamSetParameters> parameters;

	public static IEnumerable<string> Names => null;

	private static void DefineParameters(string name, DerObjectIdentifier oid, Gost3410ParamSetParameters parameterSet)
	{
	}

	static Gost3410NamedParameters()
	{
	}

	public static Gost3410ParamSetParameters GetByName(string name)
	{
		return null;
	}

	public static Gost3410ParamSetParameters GetByOid(DerObjectIdentifier oid)
	{
		return null;
	}

	public static DerObjectIdentifier GetOid(string name)
	{
		return null;
	}
}
