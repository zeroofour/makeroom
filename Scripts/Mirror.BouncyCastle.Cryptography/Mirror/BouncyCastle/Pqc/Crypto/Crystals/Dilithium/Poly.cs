namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;

internal class Poly
{
	private int N;

	private DilithiumEngine Engine;

	private int PolyUniformNBlocks;

	private Symmetric Symmetric;

	public int[] Coeffs { get; set; }

	public Poly(DilithiumEngine engine)
	{
	}

	public void UniformBlocks(byte[] seed, ushort nonce)
	{
	}

	private static int RejectUniform(int[] coeffs, int off, int len, byte[] buf, int buflen)
	{
		return 0;
	}

	public void UniformEta(byte[] seed, ushort nonce)
	{
	}

	private static int RejectEta(int[] coeffs, int off, int len, byte[] buf, int buflen, int eta)
	{
		return 0;
	}

	public void PointwiseMontgomery(Poly v, Poly w)
	{
	}

	public void PointwiseAccountMontgomery(PolyVecL u, PolyVecL v)
	{
	}

	public void AddPoly(Poly a)
	{
	}

	public void Subtract(Poly b)
	{
	}

	public void ReducePoly()
	{
	}

	public void PolyNtt()
	{
	}

	public void InverseNttToMont()
	{
	}

	public void ConditionalAddQ()
	{
	}

	public void Power2Round(Poly a)
	{
	}

	public void PolyT0Pack(byte[] r, int off)
	{
	}

	public void PolyT0Unpack(byte[] a, int off)
	{
	}

	public byte[] PolyT1Pack()
	{
		return null;
	}

	public void PolyT1Unpack(byte[] a)
	{
	}

	public void PolyEtaPack(byte[] r, int off)
	{
	}

	public void PolyEtaUnpack(byte[] a, int off)
	{
	}

	public void UniformGamma1(byte[] seed, ushort nonce)
	{
	}

	public void PackZ(byte[] r, int offset)
	{
	}

	public void UnpackZ(byte[] a)
	{
	}

	public void Decompose(Poly a)
	{
	}

	public void PackW1(byte[] r, int off)
	{
	}

	public void Challenge(byte[] seed)
	{
	}

	public bool CheckNorm(int B)
	{
		return false;
	}

	public int PolyMakeHint(Poly a0, Poly a1)
	{
		return 0;
	}

	public void PolyUseHint(Poly a, Poly h)
	{
	}

	public void ShiftLeft()
	{
	}
}
