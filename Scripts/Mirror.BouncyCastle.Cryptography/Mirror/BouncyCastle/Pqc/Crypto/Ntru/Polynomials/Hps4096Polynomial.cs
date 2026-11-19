using Mirror.BouncyCastle.Pqc.Crypto.Ntru.ParameterSets;

namespace Mirror.BouncyCastle.Pqc.Crypto.Ntru.Polynomials;

internal class Hps4096Polynomial : HpsPolynomial
{
	internal Hps4096Polynomial(NtruParameterSet parameterSet)
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
}
