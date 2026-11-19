namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;

internal class PolyVecL
{
	public readonly Poly[] Vec;

	private readonly int L;

	private readonly int K;

	public PolyVecL(DilithiumEngine Engine)
	{
	}

	public void UniformEta(byte[] seed, ushort nonce)
	{
	}

	public void CopyPolyVecL(PolyVecL OutPoly)
	{
	}

	public void InverseNttToMont()
	{
	}

	public void Ntt()
	{
	}

	public void UniformGamma1(byte[] seed, ushort nonce)
	{
	}

	public void PointwisePolyMontgomery(Poly a, PolyVecL v)
	{
	}

	public void AddPolyVecL(PolyVecL b)
	{
	}

	public void Reduce()
	{
	}

	public bool CheckNorm(int bound)
	{
		return false;
	}
}
