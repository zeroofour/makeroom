using Mirror.BouncyCastle.Pqc.Crypto.Ntru.ParameterSets;
using Mirror.BouncyCastle.Pqc.Crypto.Ntru.Polynomials;

namespace Mirror.BouncyCastle.Pqc.Crypto.Ntru;

internal class NtruSampling
{
	private readonly NtruParameterSet _parameterSet;

	internal NtruSampling(NtruParameterSet parameterSet)
	{
	}

	internal PolynomialPair SampleFg(byte[] uniformBytes)
	{
		return null;
	}

	internal PolynomialPair SampleRm(byte[] uniformBytes)
	{
		return null;
	}

	internal Polynomial SampleIid(byte[] uniformBytes)
	{
		return null;
	}

	internal HpsPolynomial SampleFixedType(byte[] uniformBytes)
	{
		return null;
	}

	internal HrssPolynomial SampleIidPlus(byte[] uniformBytes)
	{
		return null;
	}

	private static int Mod3(int a)
	{
		return 0;
	}
}
