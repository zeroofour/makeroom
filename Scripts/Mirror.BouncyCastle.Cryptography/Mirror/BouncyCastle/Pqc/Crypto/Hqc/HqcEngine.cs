namespace Mirror.BouncyCastle.Pqc.Crypto.Hqc;

internal class HqcEngine
{
	private int n;

	private int n1;

	private int n2;

	private int k;

	private int delta;

	private int w;

	private int wr;

	private int we;

	private int g;

	private int rejectionThreshold;

	private int fft;

	private int mulParam;

	private int SEED_SIZE;

	private byte G_FCT_DOMAIN;

	private byte H_FCT_DOMAIN;

	private byte K_FCT_DOMAIN;

	private int N_BYTE;

	private int n1n2;

	private int N_BYTE_64;

	private int K_BYTE;

	private int K_BYTE_64;

	private int N1_BYTE_64;

	private int N1N2_BYTE_64;

	private int N1N2_BYTE;

	private int N1_BYTE;

	private int SALT_SIZE_BYTES;

	private int[] generatorPoly;

	private int SHA512_BYTES;

	private ulong RED_MASK;

	private GF2PolynomialCalculator gfCalculator;

	public HqcEngine(int n, int n1, int n2, int k, int g, int delta, int w, int wr, int we, int rejectionThreshold, int fft, int[] generatorPoly)
	{
	}

	public void GenKeyPair(byte[] pk, byte[] sk, byte[] seed)
	{
	}

	public void Encaps(byte[] u, byte[] v, byte[] K, byte[] d, byte[] pk, byte[] seed, byte[] salt)
	{
	}

	public void Decaps(byte[] ss, byte[] ct, byte[] sk)
	{
	}

	internal int GetSessionKeySize()
	{
		return 0;
	}

	private void Encrypt(byte[] u, long[] v, long[] h, byte[] s, byte[] m, byte[] theta)
	{
	}

	private void Decrypt(byte[] output, byte[] m, byte[] u, byte[] v, long[] y)
	{
	}

	private void GenerateRandomFixedWeight(long[] output, HqcKeccakRandomGenerator random, int weight)
	{
	}

	private void GeneratePublicKeyH(long[] output, HqcKeccakRandomGenerator random)
	{
	}

	private void ExtractPublicKeys(long[] h, byte[] s, byte[] pk)
	{
	}

	private void ExtractKeysFromSecretKeys(long[] x, long[] y, byte[] pk, byte[] sk)
	{
	}

	private static void ExtractCiphertexts(byte[] u, byte[] v, byte[] d, byte[] salt, byte[] ct)
	{
	}
}
