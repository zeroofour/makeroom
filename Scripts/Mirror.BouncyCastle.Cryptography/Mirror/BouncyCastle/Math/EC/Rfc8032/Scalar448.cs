namespace Mirror.BouncyCastle.Math.EC.Rfc8032;

internal static class Scalar448
{
	internal const int Size = 14;

	private const int ScalarBytes = 57;

	private const ulong M26UL = 67108863uL;

	private const ulong M28UL = 268435455uL;

	private const int TargetLength = 447;

	private static readonly uint[] L;

	private static readonly uint[] LSq;

	private const int L_0 = 78101261;

	private const int L_1 = 141809365;

	private const int L_2 = 175155932;

	private const int L_3 = 64542499;

	private const int L_4 = 158326419;

	private const int L_5 = 191173276;

	private const int L_6 = 104575268;

	private const int L_7 = 137584065;

	private const int L4_0 = 43969588;

	private const int L4_1 = 30366549;

	private const int L4_2 = 163752818;

	private const int L4_3 = 258169998;

	private const int L4_4 = 96434764;

	private const int L4_5 = 227822194;

	private const int L4_6 = 149865618;

	private const int L4_7 = 550336261;

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

	internal static void Multiply225Var(uint[] x, uint[] y225, uint[] z)
	{
	}

	internal static byte[] Reduce704(byte[] n)
	{
		return null;
	}

	internal static byte[] Reduce912(byte[] n)
	{
		return null;
	}

	internal static bool ReduceBasisVar(uint[] k, uint[] z0, uint[] z1)
	{
		return false;
	}

	internal static void ToSignedDigits(int bits, uint[] x, uint[] z)
	{
	}
}
