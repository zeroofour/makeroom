using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Frodo;

public class FrodoEngine
{
	internal static int nbar;

	private static int mbar;

	private static int len_seedA;

	private static int len_z;

	private static int len_chi;

	private static int len_seedA_bytes;

	private static int len_z_bytes;

	private static int len_chi_bytes;

	private int D;

	private int q;

	private int n;

	private int B;

	private int len_sk_bytes;

	private int len_pk_bytes;

	private int len_ct_bytes;

	private short[] T_chi;

	private int len_mu;

	private int len_seedSE;

	private int len_s;

	private int len_k;

	private int len_pkh;

	private int len_ss;

	private int len_mu_bytes;

	private int len_seedSE_bytes;

	private int len_s_bytes;

	private int len_k_bytes;

	private int len_pkh_bytes;

	private int len_ss_bytes;

	private IDigest digest;

	private FrodoMatrixGenerator gen;

	public int CipherTextSize => 0;

	public int SessionKeySize => 0;

	public int PrivateKeySize => 0;

	public int PublicKeySize => 0;

	public FrodoEngine(int n, int D, int B, short[] cdf_table, IDigest digest, FrodoMatrixGenerator mGen)
	{
	}

	private short Sample(short r)
	{
		return 0;
	}

	private short[] SampleMatrix(short[] r, int offset, int n1, int n2)
	{
		return null;
	}

	private short[] MatrixTranspose(short[] X, int n1, int n2)
	{
		return null;
	}

	private short[] MatrixMul(short[] X, int Xrow, int Xcol, short[] Y, int Ycol)
	{
		return null;
	}

	private short[] MatrixAdd(short[] X, short[] Y, int n1, int m1)
	{
		return null;
	}

	private byte[] FrodoPack(short[] C)
	{
		return null;
	}

	public void kem_keypair(byte[] pk, byte[] sk, SecureRandom random)
	{
	}

	private short[] FrodoUnpack(byte[] input, int n1, int n2)
	{
		return null;
	}

	private short[] Encode(byte[] k)
	{
		return null;
	}

	public void kem_enc(byte[] ct, byte[] ss, byte[] pk, SecureRandom random)
	{
	}

	private short[] MatrixSub(short[] X, short[] Y, int n1, int n2)
	{
		return null;
	}

	private byte[] Decode(short[] input)
	{
		return null;
	}

	private short CTVerify(short[] a1, short[] a2, short[] b1, short[] b2)
	{
		return 0;
	}

	private byte[] CTSelect(byte[] a, byte[] b, short selector)
	{
		return null;
	}

	public void kem_dec(byte[] ss, byte[] ct, byte[] sk)
	{
	}
}
