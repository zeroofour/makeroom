using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;

internal class DilithiumEngine
{
	private SecureRandom _random;

	public const int N = 256;

	public const int Q = 8380417;

	public const int QInv = 58728449;

	public const int D = 13;

	public const int RootOfUnity = 1753;

	public const int SeedBytes = 32;

	public const int CrhBytes = 64;

	public const int RndBytes = 32;

	public const int TrBytes = 64;

	public const int PolyT1PackedBytes = 320;

	public const int PolyT0PackedBytes = 416;

	public int Mode { get; private set; }

	public int K { get; private set; }

	public int L { get; private set; }

	public int Eta { get; private set; }

	public int Tau { get; private set; }

	public int Beta { get; private set; }

	public int Gamma1 { get; private set; }

	public int Gamma2 { get; private set; }

	public int Omega { get; private set; }

	public int CTilde { get; private set; }

	public int PolyVecHPackedBytes { get; private set; }

	public int PolyZPackedBytes { get; private set; }

	public int PolyW1PackedBytes { get; private set; }

	public int PolyEtaPackedBytes { get; private set; }

	public int CryptoPublicKeyBytes { get; private set; }

	public int CryptoSecretKeyBytes { get; private set; }

	public int CryptoBytes { get; private set; }

	public int PolyUniformGamma1NBytes { get; private set; }

	public Symmetric Symmetric { get; private set; }

	public DilithiumEngine(int mode, SecureRandom random, bool usingAes)
	{
	}

	public void GenerateKeyPair(out byte[] rho, out byte[] key, out byte[] tr, out byte[] s1_, out byte[] s2_, out byte[] t0_, out byte[] encT1)
	{
		rho = null;
		key = null;
		tr = null;
		s1_ = null;
		s2_ = null;
		t0_ = null;
		encT1 = null;
	}

	public void SignSignature(byte[] sig, int siglen, byte[] msg, int msglen, byte[] rho, byte[] key, byte[] tr, byte[] t0Enc, byte[] s1Enc, byte[] s2Enc)
	{
	}

	public void Sign(byte[] sig, int siglen, byte[] msg, int mlen, byte[] rho, byte[] key, byte[] tr, byte[] t0, byte[] s1, byte[] s2)
	{
	}

	public bool SignVerify(byte[] sig, int siglen, byte[] msg, int msglen, byte[] rho, byte[] encT1)
	{
		return false;
	}

	public bool SignOpen(byte[] msg, byte[] sig, int siglen, byte[] rho, byte[] t1)
	{
		return false;
	}
}
