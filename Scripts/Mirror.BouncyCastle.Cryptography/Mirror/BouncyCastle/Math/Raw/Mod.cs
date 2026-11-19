using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Math.Raw;

internal static class Mod
{
	private const int M30 = 1073741823;

	private const ulong M32UL = 4294967295uL;

	private static readonly int MaxStackAlloc;

	public static void CheckedModOddInverse(uint[] m, uint[] x, uint[] z)
	{
	}

	public static void CheckedModOddInverseVar(uint[] m, uint[] x, uint[] z)
	{
	}

	public static uint Inverse32(uint d)
	{
		return 0u;
	}

	public static ulong Inverse64(ulong d)
	{
		return 0uL;
	}

	public static uint ModOddInverse(uint[] m, uint[] x, uint[] z)
	{
		return 0u;
	}

	public static bool ModOddInverseVar(uint[] m, uint[] x, uint[] z)
	{
		return false;
	}

	public static uint ModOddIsCoprime(uint[] m, uint[] x)
	{
		return 0u;
	}

	public static bool ModOddIsCoprimeVar(uint[] m, uint[] x)
	{
		return false;
	}

	public static uint[] Random(SecureRandom random, uint[] p)
	{
		return null;
	}

	private static int Add30(int len30, int[] D, int[] M)
	{
		return 0;
	}

	private static void CNegate30(int len30, int cond, int[] D)
	{
	}

	private static void CNormalize30(int len30, int condNegate, int[] D, int[] M)
	{
	}

	private static void Decode30(int bits, int[] x, uint[] z)
	{
	}

	private static int Divsteps30Var(int eta, int f0, int g0, int[] t)
	{
		return 0;
	}

	private static void Encode30(int bits, uint[] x, int[] z)
	{
	}

	private static int EqualTo(int len, int[] x, int y)
	{
		return 0;
	}

	private static bool EqualToVar(int len, int[] x, int y)
	{
		return false;
	}

	private static int GetMaximumDivsteps(int bits)
	{
		return 0;
	}

	private static int GetMaximumHDDivsteps(int bits)
	{
		return 0;
	}

	private static int HDDivsteps30(int theta, int f0, int g0, int[] t)
	{
		return 0;
	}

	private static int Negate30(int len30, int[] D)
	{
		return 0;
	}

	private static int TrimFG30Var(int len30, int[] F, int[] G)
	{
		return 0;
	}

	private static void UpdateDE30(int len30, int[] D, int[] E, int[] t, int m0Inv32, int[] M)
	{
	}

	private static void UpdateFG30(int len30, int[] F, int[] G, int[] t)
	{
	}
}
