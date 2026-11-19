using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1.X9;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Math.EC;

namespace Mirror.BouncyCastle.Asn1.CryptoPro;

public static class ECGost3410NamedCurves
{
	internal class Holder_gostR3410_2001_CryptoPro_A : X9ECParametersHolder
	{
		internal static readonly X9ECParametersHolder Instance;

		private Holder_gostR3410_2001_CryptoPro_A()
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

	internal class Holder_gostR3410_2001_CryptoPro_B : X9ECParametersHolder
	{
		internal static readonly X9ECParametersHolder Instance;

		private Holder_gostR3410_2001_CryptoPro_B()
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

	internal class Holder_gostR3410_2001_CryptoPro_C : X9ECParametersHolder
	{
		internal static readonly X9ECParametersHolder Instance;

		private Holder_gostR3410_2001_CryptoPro_C()
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

	internal class Holder_id_tc26_gost_3410_12_256_paramSetA : X9ECParametersHolder
	{
		internal static readonly X9ECParametersHolder Instance;

		private Holder_id_tc26_gost_3410_12_256_paramSetA()
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

	internal class Holder_id_tc26_gost_3410_12_512_paramSetA : X9ECParametersHolder
	{
		internal static readonly X9ECParametersHolder Instance;

		private Holder_id_tc26_gost_3410_12_512_paramSetA()
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

	internal class Holder_id_tc26_gost_3410_12_512_paramSetB : X9ECParametersHolder
	{
		internal static readonly X9ECParametersHolder Instance;

		private Holder_id_tc26_gost_3410_12_512_paramSetB()
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

	internal class Holder_id_tc26_gost_3410_12_512_paramSetC : X9ECParametersHolder
	{
		internal static readonly X9ECParametersHolder Instance;

		private Holder_id_tc26_gost_3410_12_512_paramSetC()
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

	private static X9ECPoint ConfigureBasepoint(ECCurve curve, BigInteger x, BigInteger y)
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

	static ECGost3410NamedCurves()
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
