namespace Mirror.BouncyCastle.Math.EC.Rfc8032;

internal static class Scalar25519
{
	internal const int Size = 8;

	private const int ScalarBytes = 32;

	private const long M28L = 268435455L;

	private const int TargetLength = 254;

	private static readonly uint[] L;

	private static readonly uint[] LSq;

	private const int L0 = -50998291;

	private const int L1 = 19280294;

	private const int L2 = 127719000;

	private const int L3 = -6428113;

	private const int L4 = 5343;

	internal static bool CheckVar(byte[] s, uint[] n)
	{
		return false;
	}

	internal static void Decode(byte[] k, uint[] n)
	{
	}

	internal static void GetOrderWnafVar(int width, sbyte[] ws)
	{
	}

	internal static void Multiply128Var(uint[] x, uint[] y128, uint[] z)
	{
	}

	internal static byte[] Reduce384(byte[] n)
	{
		return null;
	}

	internal static byte[] Reduce512(byte[] n)
	{
		return null;
	}

	internal static bool ReduceBasisVar(uint[] k, uint[] z0, uint[] z1)
	{
		return false;
	}

	internal static void ToSignedDigits(int bits, uint[] z)
	{
	}
}
