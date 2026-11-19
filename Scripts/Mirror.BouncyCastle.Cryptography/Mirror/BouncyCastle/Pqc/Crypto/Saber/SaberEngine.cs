using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Saber;

internal sealed class SaberEngine
{
	internal const int SABER_EP = 10;

	internal const int SABER_N = 256;

	private const int SABER_SEEDBYTES = 32;

	private const int SABER_NOISE_SEEDBYTES = 32;

	private const int SABER_KEYBYTES = 32;

	private const int SABER_HASHBYTES = 32;

	private readonly int SABER_L;

	private readonly int SABER_MU;

	private readonly int SABER_ET;

	private readonly int SABER_POLYCOINBYTES;

	private readonly int SABER_EQ;

	private readonly int SABER_POLYBYTES;

	private readonly int SABER_POLYVECBYTES;

	private readonly int SABER_POLYCOMPRESSEDBYTES;

	private readonly int SABER_POLYVECCOMPRESSEDBYTES;

	private readonly int SABER_SCALEBYTES_KEM;

	private readonly int SABER_INDCPA_PUBLICKEYBYTES;

	private readonly int SABER_INDCPA_SECRETKEYBYTES;

	private readonly int SABER_PUBLICKEYBYTES;

	private readonly int SABER_SECRETKEYBYTES;

	private readonly int SABER_BYTES_CCA_DEC;

	private readonly int defaultKeySize;

	private int h1;

	private int h2;

	private Symmetric symmetric;

	private SaberUtilities utils;

	private Poly poly;

	private readonly bool usingAes;

	private readonly bool usingEffectiveMasking;

	public bool UsingAes => false;

	public bool UsingEffectiveMasking => false;

	public Symmetric Symmetric => null;

	public int EQ => 0;

	public int N => 0;

	public int EP => 0;

	public int KeyBytes => 0;

	public int L => 0;

	public int ET => 0;

	public int PolyBytes => 0;

	public int PolyVecBytes => 0;

	public int SeedBytes => 0;

	public int PolyCoinBytes => 0;

	public int NoiseSeedBytes => 0;

	public int MU => 0;

	public SaberUtilities Utilities => null;

	public int GetSessionKeySize()
	{
		return 0;
	}

	public int GetCipherTextSize()
	{
		return 0;
	}

	public int GetPublicKeySize()
	{
		return 0;
	}

	public int GetPrivateKeySize()
	{
		return 0;
	}

	internal SaberEngine(int l, int defaultKeySize, bool usingAes, bool usingEffectiveMasking)
	{
	}

	private void indcpa_kem_keypair(byte[] pk, byte[] sk, SecureRandom random)
	{
	}

	public int crypto_kem_keypair(byte[] pk, byte[] sk, SecureRandom random)
	{
		return 0;
	}

	private void indcpa_kem_enc(byte[] m, byte[] seed_sp, byte[] pk, byte[] ciphertext)
	{
	}

	public int crypto_kem_enc(byte[] c, byte[] k, byte[] pk, SecureRandom random)
	{
		return 0;
	}

	private void indcpa_kem_dec(byte[] sk, byte[] ciphertext, byte[] m)
	{
	}

	public int crypto_kem_dec(byte[] k, byte[] c, byte[] sk)
	{
		return 0;
	}

	private static int verify(byte[] a, byte[] b, int len)
	{
		return 0;
	}

	private static void cmov(byte[] r, byte[] x, int x_offset, int len, byte b)
	{
	}
}
