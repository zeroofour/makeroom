using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Sike;

internal sealed class SikeEngine
{
	internal Internal param;

	internal Isogeny isogeny;

	internal Fpx fpx;

	private Sidh sidh;

	private SidhCompressed sidhCompressed;

	private bool isCompressed;

	internal uint GetDefaultSessionKeySize()
	{
		return 0u;
	}

	internal int GetCipherTextSize()
	{
		return 0;
	}

	internal uint GetPrivateKeySize()
	{
		return 0u;
	}

	internal uint GetPublicKeySize()
	{
		return 0u;
	}

	internal SikeEngine(int ver, bool isCompressed, SecureRandom random)
	{
	}

	internal int crypto_kem_keypair(byte[] pk, byte[] sk, SecureRandom random)
	{
		return 0;
	}

	internal int crypto_kem_enc(byte[] ct, byte[] ss, byte[] pk, SecureRandom random)
	{
		return 0;
	}

	internal int crypto_kem_dec(byte[] ss, byte[] ct, byte[] sk)
	{
		return 0;
	}
}
