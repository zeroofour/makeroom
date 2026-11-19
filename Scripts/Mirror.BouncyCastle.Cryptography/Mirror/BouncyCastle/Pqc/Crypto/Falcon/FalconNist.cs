using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Falcon;

internal class FalconNist
{
	private FalconCodec codec;

	private FalconVrfy vrfy;

	private FalconCommon common;

	private SecureRandom random;

	private uint logn;

	private uint noncelen;

	private int CRYPTO_BYTES;

	private int CRYPTO_PUBLICKEYBYTES;

	private int CRYPTO_SECRETKEYBYTES;

	internal uint NonceLength => 0u;

	internal uint LogN => 0u;

	internal int CryptoBytes => 0;

	internal FalconNist(SecureRandom random, uint logn, uint noncelen)
	{
	}

	internal int crypto_sign_keypair(out byte[] pk, out byte[] fEnc, out byte[] gEnc, out byte[] FEnc)
	{
		pk = null;
		fEnc = null;
		gEnc = null;
		FEnc = null;
		return 0;
	}

	internal byte[] crypto_sign(bool attached, byte[] sm, byte[] msrc, int m, uint mlen, byte[] sksrc, int sk)
	{
		return null;
	}

	internal int crypto_sign_open(bool attached, byte[] sig_encoded, byte[] nonce, byte[] m, byte[] pksrc, int pk)
	{
		return 0;
	}
}
