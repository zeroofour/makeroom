namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Kyber;

internal class PolyVec
{
	private KyberEngine m_engine;

	internal Poly[] m_vec;

	internal PolyVec(KyberEngine engine)
	{
	}

	internal void Ntt()
	{
	}

	internal void InverseNttToMont()
	{
	}

	internal static void PointwiseAccountMontgomery(Poly r, PolyVec a, PolyVec b, KyberEngine engine)
	{
	}

	internal void Add(PolyVec a)
	{
	}

	internal void Reduce()
	{
	}

	internal void CompressPolyVec(byte[] r)
	{
	}

	internal void DecompressPolyVec(byte[] compressedCipherText)
	{
	}

	internal void ToBytes(byte[] r)
	{
	}

	internal void FromBytes(byte[] pk)
	{
	}

	private void ConditionalSubQ()
	{
	}
}
