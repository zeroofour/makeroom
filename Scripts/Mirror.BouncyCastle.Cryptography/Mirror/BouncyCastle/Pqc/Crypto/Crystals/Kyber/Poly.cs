namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Kyber;

internal class Poly
{
	private KyberEngine m_engine;

	public short[] m_coeffs;

	private Symmetric m_symmetric;

	internal short[] Coeffs => null;

	public Poly(KyberEngine mEngine)
	{
	}

	internal void GetNoiseEta1(byte[] seed, byte nonce)
	{
	}

	internal void GetNoiseEta2(byte[] seed, byte nonce)
	{
	}

	internal void PolyNtt()
	{
	}

	internal void PolyInverseNttToMont()
	{
	}

	internal static void BaseMultMontgomery(Poly r, Poly a, Poly b)
	{
	}

	internal void ToMont()
	{
	}

	internal void Add(Poly a)
	{
	}

	internal void Subtract(Poly a)
	{
	}

	internal void PolyReduce()
	{
	}

	internal void CompressPoly(byte[] r, int off)
	{
	}

	internal void DecompressPoly(byte[] CompressedCipherText, int off)
	{
	}

	internal void ToBytes(byte[] r, int off)
	{
	}

	internal void FromBytes(byte[] a, int off)
	{
	}

	internal void ToMsg(byte[] msg)
	{
	}

	internal void FromMsg(byte[] m)
	{
	}

	internal void CondSubQ()
	{
	}
}
