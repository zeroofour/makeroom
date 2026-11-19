namespace Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

internal abstract class HarakaSBase
{
	private static readonly byte[] RC0;

	private static readonly byte[] RC1;

	private static readonly byte[] RC2;

	private static readonly byte[] RC3;

	private static readonly byte[] RC4;

	private static readonly byte[] RC5;

	private static readonly byte[] RC6;

	private static readonly byte[] RC7;

	private static readonly byte[] RC8;

	private static readonly byte[] RC9;

	private static readonly byte[] RC10;

	private static readonly byte[] RC11;

	private static readonly byte[] RC12;

	private static readonly byte[] RC13;

	private static readonly byte[] RC14;

	private static readonly byte[] RC15;

	private static readonly byte[] RC16;

	private static readonly byte[] RC17;

	private static readonly byte[] RC18;

	private static readonly byte[] RC19;

	private static readonly byte[] RC20;

	private static readonly byte[] RC21;

	private static readonly byte[] RC22;

	private static readonly byte[] RC23;

	private static readonly byte[] RC24;

	private static readonly byte[] RC25;

	private static readonly byte[] RC26;

	private static readonly byte[] RC27;

	private static readonly byte[] RC28;

	private static readonly byte[] RC29;

	private static readonly byte[] RC30;

	private static readonly byte[] RC31;

	private static readonly byte[] RC32;

	private static readonly byte[] RC33;

	private static readonly byte[] RC34;

	private static readonly byte[] RC35;

	private static readonly byte[] RC36;

	private static readonly byte[] RC37;

	private static readonly byte[] RC38;

	private static readonly byte[] RC39;

	private static readonly byte[][] RoundConstants;

	internal ulong[][] haraka512_rc;

	internal uint[][] haraka256_rc;

	protected readonly byte[] buffer;

	protected int off;

	protected void Reset()
	{
	}

	protected static void InterleaveConstant(ulong[] output, byte[] input, int startPos)
	{
	}

	protected static void InterleaveConstant32(uint[] output, byte[] input, int startPos)
	{
	}

	internal void Haraka512Perm(byte[] output)
	{
	}

	internal void Haraka256Perm(byte[] output)
	{
	}

	private static void BrAesCt64InterleaveIn(ulong[] q, int qPos, uint[] w, int startPos)
	{
	}

	private static void BrAesCtBitsliceSbox(uint[] q)
	{
	}

	private static void ShiftRows32(uint[] q)
	{
	}

	private static void MixColumns32(uint[] q)
	{
	}

	private static void AddRoundKey32(uint[] q, uint[] sk)
	{
	}

	private static void BrAesCt64Ortho(ulong[] q)
	{
	}

	private static void BrAesCtOrtho(uint[] q)
	{
	}

	private static void BrAesCt64BitsliceSbox(ulong[] q)
	{
	}

	private static void ShiftRows(ulong[] q)
	{
	}

	private static void MixColumns(ulong[] q)
	{
	}

	private static void AddRoundKey(ulong[] q, ulong[] sk)
	{
	}

	private static void BrAesCt64InterleaveOut(uint[] w, ulong[] q, int pos)
	{
	}

	protected static void Xor(byte[] x, int xOff, byte[] y, int yOff, byte[] z, int zOff, int zLen)
	{
	}
}
