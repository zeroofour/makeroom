using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Kyber;

internal class KyberEngine
{
	private SecureRandom m_random;

	private KyberIndCpa m_indCpa;

	public const int N = 256;

	public const int Q = 3329;

	public const int QInv = 62209;

	public static int SymBytes;

	private const int SharedSecretBytes = 32;

	public static int PolyBytes;

	public const int Eta2 = 2;

	public int IndCpaMsgBytes;

	public Symmetric Symmetric { get; private set; }

	public int K { get; private set; }

	public int PolyVecBytes { get; private set; }

	public int PolyCompressedBytes { get; private set; }

	public int PolyVecCompressedBytes { get; private set; }

	public int Eta1 { get; private set; }

	public int IndCpaPublicKeyBytes { get; private set; }

	public int IndCpaSecretKeyBytes { get; private set; }

	public int IndCpaBytes { get; private set; }

	public int PublicKeyBytes { get; private set; }

	public int SecretKeyBytes { get; private set; }

	public int CipherTextBytes { get; private set; }

	public int CryptoBytes { get; private set; }

	public int CryptoSecretKeyBytes { get; private set; }

	public int CryptoPublicKeyBytes { get; private set; }

	public int CryptoCipherTextBytes { get; private set; }

	public KyberEngine(int k, bool usingAes)
	{
	}

	internal void Init(SecureRandom random)
	{
	}

	internal void GenerateKemKeyPair(out byte[] t, out byte[] rho, out byte[] s, out byte[] hpk, out byte[] nonce)
	{
		t = null;
		rho = null;
		s = null;
		hpk = null;
		nonce = null;
	}

	internal void KemEncrypt(byte[] cipherText, byte[] sharedSecret, byte[] pk)
	{
	}

	internal void KemDecrypt(byte[] sharedSecret, byte[] cipherText, byte[] secretKey)
	{
	}

	private void CMov(byte[] r, byte[] x, int len, bool b)
	{
	}

	internal void RandomBytes(byte[] buf, int len)
	{
	}
}
