using Mirror.BouncyCastle.Pqc.Crypto.Ntru.Polynomials;

namespace Mirror.BouncyCastle.Pqc.Crypto.Ntru.ParameterSets;

internal class NtruHpsParameterSet : NtruParameterSet
{
	private protected NtruHpsParameterSet(int n, int logQ, int seedBytes, int prfKeyBytes, int sharedKeyBytes)
		: base(0, 0, 0, 0, 0)
	{
	}

	internal override Polynomial CreatePolynomial()
	{
		return null;
	}

	internal override int SampleFgBytes()
	{
		return 0;
	}

	internal override int SampleRmBytes()
	{
		return 0;
	}

	internal int Weight()
	{
		return 0;
	}
}
