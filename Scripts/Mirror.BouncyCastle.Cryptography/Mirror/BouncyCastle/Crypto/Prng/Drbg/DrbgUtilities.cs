using System.Collections.Generic;

namespace Mirror.BouncyCastle.Crypto.Prng.Drbg;

internal class DrbgUtilities
{
	private static readonly IDictionary<string, int> MaxSecurityStrengths;

	static DrbgUtilities()
	{
	}

	internal static int GetMaxSecurityStrength(IDigest d)
	{
		return 0;
	}

	internal static int GetMaxSecurityStrength(IMac m)
	{
		return 0;
	}

	internal static void HashDF(IDigest digest, byte[] seedMaterial, int seedLength, byte[] output)
	{
	}
}
