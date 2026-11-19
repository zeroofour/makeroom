namespace Mirror.BouncyCastle.Tls;

public abstract class NamedGroup
{
	public const int sect163k1 = 1;

	public const int sect163r1 = 2;

	public const int sect163r2 = 3;

	public const int sect193r1 = 4;

	public const int sect193r2 = 5;

	public const int sect233k1 = 6;

	public const int sect233r1 = 7;

	public const int sect239k1 = 8;

	public const int sect283k1 = 9;

	public const int sect283r1 = 10;

	public const int sect409k1 = 11;

	public const int sect409r1 = 12;

	public const int sect571k1 = 13;

	public const int sect571r1 = 14;

	public const int secp160k1 = 15;

	public const int secp160r1 = 16;

	public const int secp160r2 = 17;

	public const int secp192k1 = 18;

	public const int secp192r1 = 19;

	public const int secp224k1 = 20;

	public const int secp224r1 = 21;

	public const int secp256k1 = 22;

	public const int secp256r1 = 23;

	public const int secp384r1 = 24;

	public const int secp521r1 = 25;

	public const int brainpoolP256r1 = 26;

	public const int brainpoolP384r1 = 27;

	public const int brainpoolP512r1 = 28;

	public const int x25519 = 29;

	public const int x448 = 30;

	public const int brainpoolP256r1tls13 = 31;

	public const int brainpoolP384r1tls13 = 32;

	public const int brainpoolP512r1tls13 = 33;

	public const int GC256A = 34;

	public const int GC256B = 35;

	public const int GC256C = 36;

	public const int GC256D = 37;

	public const int GC512A = 38;

	public const int GC512B = 39;

	public const int GC512C = 40;

	public const int curveSM2 = 41;

	public const int ffdhe2048 = 256;

	public const int ffdhe3072 = 257;

	public const int ffdhe4096 = 258;

	public const int ffdhe6144 = 259;

	public const int ffdhe8192 = 260;

	public const int arbitrary_explicit_prime_curves = 65281;

	public const int arbitrary_explicit_char2_curves = 65282;

	private static readonly string[] CurveNames;

	private static readonly string[] FiniteFieldNames;

	public static bool CanBeNegotiated(int namedGroup, ProtocolVersion version)
	{
		return false;
	}

	public static int GetCurveBits(int namedGroup)
	{
		return 0;
	}

	public static string GetCurveName(int namedGroup)
	{
		return null;
	}

	public static int GetFiniteFieldBits(int namedGroup)
	{
		return 0;
	}

	public static string GetFiniteFieldName(int namedGroup)
	{
		return null;
	}

	public static int GetMaximumChar2CurveBits()
	{
		return 0;
	}

	public static int GetMaximumCurveBits()
	{
		return 0;
	}

	public static int GetMaximumFiniteFieldBits()
	{
		return 0;
	}

	public static int GetMaximumPrimeCurveBits()
	{
		return 0;
	}

	public static string GetName(int namedGroup)
	{
		return null;
	}

	public static string GetStandardName(int namedGroup)
	{
		return null;
	}

	public static string GetText(int namedGroup)
	{
		return null;
	}

	public static bool IsChar2Curve(int namedGroup)
	{
		return false;
	}

	public static bool IsFiniteField(int namedGroup)
	{
		return false;
	}

	public static bool IsPrimeCurve(int namedGroup)
	{
		return false;
	}

	public static bool IsPrivate(int namedGroup)
	{
		return false;
	}

	public static bool IsValid(int namedGroup)
	{
		return false;
	}

	public static bool RefersToAnECDHCurve(int namedGroup)
	{
		return false;
	}

	public static bool RefersToAnECDSACurve(int namedGroup)
	{
		return false;
	}

	public static bool RefersToAnXDHCurve(int namedGroup)
	{
		return false;
	}

	public static bool RefersToASpecificCurve(int namedGroup)
	{
		return false;
	}

	public static bool RefersToASpecificFiniteField(int namedGroup)
	{
		return false;
	}

	public static bool RefersToASpecificGroup(int namedGroup)
	{
		return false;
	}
}
