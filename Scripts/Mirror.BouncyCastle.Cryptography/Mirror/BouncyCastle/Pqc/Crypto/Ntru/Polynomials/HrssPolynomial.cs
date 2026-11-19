using Mirror.BouncyCastle.Pqc.Crypto.Ntru.ParameterSets;

namespace Mirror.BouncyCastle.Pqc.Crypto.Ntru.Polynomials;

internal class HrssPolynomial : Polynomial
{
	internal HrssPolynomial(NtruParameterSet parameterSet)
		: base(null)
	{
	}

	public override byte[] SqToBytes(int len)
	{
		return null;
	}

	public override void SqFromBytes(byte[] a)
	{
	}

	public override void Lift(Polynomial a)
	{
	}

	public override void R2Inv(Polynomial a)
	{
	}

	public override void RqInv(Polynomial a)
	{
	}

	public override void S3Inv(Polynomial a)
	{
	}
}
