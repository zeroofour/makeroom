using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1.X9;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Math.EC;

namespace Mirror.BouncyCastle.Asn1.Anssi;

public static class AnssiNamedCurves
{
	internal class Frp256v1Holder : X9ECParametersHolder
	{
		internal static readonly X9ECParametersHolder Instance;

		private Frp256v1Holder()
		{
		}

		protected override ECCurve CreateCurve()
		{
			return null;
		}

		protected override X9ECParameters CreateParameters()
		{
			return null;
		}
	}

	private static readonly Dictionary<string, DerObjectIdentifier> objIds;

	private static readonly Dictionary<DerObjectIdentifier, X9ECParametersHolder> curves;

	private static readonly Dictionary<DerObjectIdentifier, string> names;

	public static IEnumerable<string> Names => null;

	private static X9ECPoint ConfigureBasepoint(ECCurve curve, string encoding)
	{
		return null;
	}

	private static ECCurve ConfigureCurve(ECCurve curve)
	{
		return null;
	}

	private static BigInteger FromHex(string hex)
	{
		return null;
	}

	private static void DefineCurve(string name, DerObjectIdentifier oid, X9ECParametersHolder holder)
	{
	}

	static AnssiNamedCurves()
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
