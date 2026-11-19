namespace Mirror.BouncyCastle.Pqc.Crypto.Saber;

internal class Poly
{
	private const int KARATSUBA_N = 64;

	private readonly int N_SB;

	private readonly int N_SB_RES;

	private readonly int SABER_N;

	private readonly int SABER_L;

	private readonly SaberEngine engine;

	private readonly SaberUtilities utils;

	public Poly(SaberEngine engine)
	{
	}

	public void GenMatrix(short[][][] A, byte[] seed)
	{
	}

	public void GenSecret(short[][] s, byte[] seed)
	{
	}

	private long LoadLittleEndian(byte[] x, int offset, int bytes)
	{
		return 0L;
	}

	private void Cbd(short[] s, byte[] buf, int offset)
	{
	}

	private short OVERFLOWING_MUL(int x, int y)
	{
		return 0;
	}

	private void karatsuba_simple(int[] a_1, int[] b_1, int[] result_final)
	{
	}

	private void toom_cook_4way(short[] a1, short[] b1, short[] result)
	{
	}

	private void poly_mul_acc(short[] a, short[] b, short[] res)
	{
	}

	public void MatrixVectorMul(short[][][] A, short[][] s, short[][] res, int transpose)
	{
	}

	public void InnerProd(short[][] b, short[][] s, short[] res)
	{
	}
}
