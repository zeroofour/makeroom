namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;

internal class PolyVecK
{
	public readonly Poly[] Vec;

	private readonly DilithiumEngine Engine;

	private readonly int K;

	public PolyVecK(DilithiumEngine Engine)
	{
	}

	public void UniformEta(byte[] seed, ushort nonce)
	{
	}

	public void Reduce()
	{
	}

	public void Ntt()
	{
	}

	public void InverseNttToMont()
	{
	}

	public void AddPolyVecK(PolyVecK b)
	{
	}

	public void Subtract(PolyVecK v)
	{
	}

	public void ConditionalAddQ()
	{
	}

	public void Power2Round(PolyVecK v)
	{
	}

	public void Decompose(PolyVecK v)
	{
	}

	public void PackW1(byte[] r)
	{
	}

	public void PointwisePolyMontgomery(Poly a, PolyVecK v)
	{
	}

	public bool CheckNorm(int bound)
	{
		return false;
	}

	public int MakeHint(PolyVecK v0, PolyVecK v1)
	{
		return 0;
	}

	public void UseHint(PolyVecK a, PolyVecK h)
	{
	}

	public void ShiftLeft()
	{
	}
}
