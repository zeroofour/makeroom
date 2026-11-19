namespace Mirror.BouncyCastle.Pqc.Crypto.Cmce;

internal abstract class Benes
{
	private static readonly ulong[] TransposeMasks;

	protected readonly int SYS_N;

	protected readonly int SYS_T;

	protected readonly int GFBITS;

	internal Benes(int n, int t, int m)
	{
	}

	internal static void Transpose64x64(ulong[] output, ulong[] input)
	{
	}

	internal static void Transpose64x64(ulong[] output, ulong[] input, int offset)
	{
	}

	internal abstract void SupportGen(ushort[] s, byte[] c);
}
