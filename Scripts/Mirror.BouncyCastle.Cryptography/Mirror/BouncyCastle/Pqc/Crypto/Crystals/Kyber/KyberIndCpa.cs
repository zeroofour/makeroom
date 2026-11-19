namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Kyber;

internal class KyberIndCpa
{
	private readonly KyberEngine m_engine;

	private Symmetric m_symmetric;

	private int GenerateMatrixNBlocks => 0;

	internal KyberIndCpa(KyberEngine mEngine)
	{
	}

	private void GenerateMatrix(PolyVec[] a, byte[] seed, bool transposed)
	{
	}

	private int RejectionSampling(short[] r, int off, int len, byte[] buf, int buflen)
	{
		return 0;
	}

	internal void GenerateKeyPair(out byte[] pk, out byte[] sk)
	{
		pk = null;
		sk = null;
	}

	private void PackSecretKey(out byte[] sk, PolyVec skpv)
	{
		sk = null;
	}

	private void UnpackSecretKey(PolyVec skpv, byte[] sk)
	{
	}

	private void PackPublicKey(out byte[] pk, PolyVec pkpv, byte[] seed)
	{
		pk = null;
	}

	private void UnpackPublicKey(PolyVec pkpv, byte[] seed, byte[] pk)
	{
	}

	public void Encrypt(byte[] c, byte[] m, byte[] pk, byte[] coins)
	{
	}

	private void PackCipherText(byte[] r, PolyVec b, Poly v)
	{
	}

	private void UnpackCipherText(PolyVec b, Poly v, byte[] c)
	{
	}

	internal void Decrypt(byte[] m, byte[] c, byte[] sk)
	{
	}
}
