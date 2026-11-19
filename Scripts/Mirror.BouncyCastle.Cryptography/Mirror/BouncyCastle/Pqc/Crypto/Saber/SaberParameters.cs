using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Saber;

public sealed class SaberParameters : ICipherParameters
{
	public static SaberParameters lightsaberkem128r3;

	public static SaberParameters saberkem128r3;

	public static SaberParameters firesaberkem128r3;

	public static SaberParameters lightsaberkem192r3;

	public static SaberParameters saberkem192r3;

	public static SaberParameters firesaberkem192r3;

	public static SaberParameters lightsaberkem256r3;

	public static SaberParameters saberkem256r3;

	public static SaberParameters firesaberkem256r3;

	public static SaberParameters lightsaberkem90sr3;

	public static SaberParameters saberkem90sr3;

	public static SaberParameters firesaberkem90sr3;

	public static SaberParameters ulightsaberkemr3;

	public static SaberParameters usaberkemr3;

	public static SaberParameters ufiresaberkemr3;

	public static SaberParameters ulightsaberkem90sr3;

	public static SaberParameters usaberkem90sr3;

	public static SaberParameters ufiresaberkem90sr3;

	private readonly string name;

	private readonly int l;

	private readonly int defaultKeySize;

	private readonly SaberEngine engine;

	public string Name => null;

	public int L => 0;

	public int DefaultKeySize => 0;

	internal SaberEngine Engine => null;

	private SaberParameters(string name, int l, int defaultKeySize, bool usingAes, bool usingEffectiveMasking)
	{
	}
}
