using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Cmce;

public sealed class CmceParameters : ICipherParameters
{
	private static readonly int[] poly3488;

	private static readonly int[] poly4608;

	private static readonly int[] poly6688;

	private static readonly int[] poly6960;

	private static readonly int[] poly8192;

	public static readonly CmceParameters mceliece348864r3;

	public static readonly CmceParameters mceliece348864fr3;

	public static readonly CmceParameters mceliece460896r3;

	public static readonly CmceParameters mceliece460896fr3;

	public static readonly CmceParameters mceliece6688128r3;

	public static readonly CmceParameters mceliece6688128fr3;

	public static readonly CmceParameters mceliece6960119r3;

	public static readonly CmceParameters mceliece6960119fr3;

	public static readonly CmceParameters mceliece8192128r3;

	public static readonly CmceParameters mceliece8192128fr3;

	private readonly string name;

	private readonly int m;

	private readonly int n;

	private readonly int t;

	private readonly bool usePivots;

	private readonly int defaultKeySize;

	private readonly ICmceEngine engine;

	public string Name => null;

	public int M => 0;

	public int N => 0;

	public int T => 0;

	public int Mu => 0;

	public int Nu => 0;

	public int DefaultKeySize => 0;

	internal ICmceEngine Engine => null;

	private CmceParameters(string name, int m, int n, int t, int[] p, bool usePivots, int defaultKeySize)
	{
	}
}
