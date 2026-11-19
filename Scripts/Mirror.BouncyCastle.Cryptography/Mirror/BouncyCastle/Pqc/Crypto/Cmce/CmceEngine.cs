using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Cmce;

internal class CmceEngine<GFImpl> : ICmceEngine where GFImpl : struct, GF
{
	private int SYS_N;

	private int SYS_T;

	private int GFBITS;

	private int IRR_BYTES;

	private int COND_BYTES;

	private int PK_NROWS;

	private int PK_NCOLS;

	private int PK_ROW_BYTES;

	private int SYND_BYTES;

	private int GFMASK;

	private int[] poly;

	private int defaultKeySize;

	private readonly GFImpl gf;

	private readonly Benes benes;

	private bool usePadding;

	private bool countErrorIndices;

	private bool usePivots;

	public int IrrBytes => 0;

	public int CondBytes => 0;

	public int PrivateKeySize => 0;

	public int PublicKeySize => 0;

	public int CipherTextSize => 0;

	public int DefaultSessionKeySize => 0;

	internal CmceEngine(int m, int n, int t, int[] p, bool usePivots, int defaultKeySize)
	{
	}

	public byte[] GeneratePublicKeyFromPrivateKey(byte[] sk)
	{
		return null;
	}

	public byte[] DecompressPrivateKey(byte[] sk)
	{
		return null;
	}

	public void KemKeypair(byte[] pk, byte[] sk, SecureRandom random)
	{
	}

	private void Syndrome(byte[] cipher_text, byte[] pk, byte[] error_vector)
	{
	}

	private void GenerateErrorVector(byte[] error_vector, SecureRandom random)
	{
	}

	private void Encrypt(byte[] cipher_text, byte[] pk, byte[] error_vector, SecureRandom random)
	{
	}

	public int KemEnc(byte[] cipher_text, byte[] key, byte[] pk, SecureRandom random)
	{
		return 0;
	}

	public int KemDec(byte[] key, byte[] cipher_text, byte[] sk)
	{
		return 0;
	}

	private int Decrypt(byte[] error_vector, byte[] sk, byte[] cipher_text)
	{
		return 0;
	}

	private static int Min(ushort a, int b)
	{
		return 0;
	}

	private void BM(ushort[] output, ushort[] s)
	{
	}

	private void Synd(ushort[] output, ushort[] f, ushort[] L, byte[] r)
	{
	}

	private int MovColumns(byte[][] mat, ushort[] pi, ulong[] pivots)
	{
		return 0;
	}

	private static int Ctz(ulong input)
	{
		return 0;
	}

	private static ulong SameMask64(ushort x, ushort y)
	{
		return 0uL;
	}

	private static byte SameMask32(short x, short y)
	{
		return 0;
	}

	private static void Layer(ushort[] p, byte[] output, int ptrIndex, int s, int n)
	{
	}

	private static void ControlBitsFromPermutation(byte[] output, ushort[] pi, long w, long n)
	{
	}

	private static short GetQShort(int[] temp, int q_index)
	{
		return 0;
	}

	private static void CBRecursion(byte[] output, long pos, long step, ushort[] pi, int qIndex, long w, long n, int[] temp)
	{
	}

	private int PKGen(byte[] pk, byte[] sk, uint[] perm, ushort[] pi, ulong[] pivots)
	{
		return 0;
	}

	private ushort Eval(ushort[] f, ushort a)
	{
		return 0;
	}

	private void Root(ushort[] output, ushort[] f, ushort[] L)
	{
	}

	private int GenerateIrrPoly(ushort[] field)
	{
		return 0;
	}

	private int CheckPKPadding(byte[] pk)
	{
		return 0;
	}

	private int CheckCPadding(byte[] c)
	{
		return 0;
	}

	private static void Sort32(int[] temp, int from, int to)
	{
	}

	private static void Sort64(long[] temp, int from, int to)
	{
	}
}
