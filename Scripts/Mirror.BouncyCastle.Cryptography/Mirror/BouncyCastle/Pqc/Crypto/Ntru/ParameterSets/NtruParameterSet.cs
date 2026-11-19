using Mirror.BouncyCastle.Pqc.Crypto.Ntru.Polynomials;

namespace Mirror.BouncyCastle.Pqc.Crypto.Ntru.ParameterSets;

internal abstract class NtruParameterSet
{
	internal int N { get; }

	internal int LogQ { get; }

	internal int SeedBytes { get; }

	internal int PrfKeyBytes { get; }

	internal int SharedKeyBytes { get; }

	internal NtruParameterSet(int n, int logQ, int seedBytes, int prfKeyBytes, int sharedKeyBytes)
	{
	}

	internal abstract Polynomial CreatePolynomial();

	internal int Q()
	{
		return 0;
	}

	internal int SampleIidBytes()
	{
		return 0;
	}

	internal int SampleFixedTypeBytes()
	{
		return 0;
	}

	internal abstract int SampleFgBytes();

	internal abstract int SampleRmBytes();

	internal int PackDegree()
	{
		return 0;
	}

	internal int PackTrinaryBytes()
	{
		return 0;
	}

	internal int OwcpaMsgBytes()
	{
		return 0;
	}

	internal int OwcpaPublicKeyBytes()
	{
		return 0;
	}

	internal int OwcpaSecretKeyBytes()
	{
		return 0;
	}

	internal int OwcpaBytes()
	{
		return 0;
	}

	internal int NtruPublicKeyBytes()
	{
		return 0;
	}

	internal int NtruSecretKeyBytes()
	{
		return 0;
	}

	internal int NtruCiphertextBytes()
	{
		return 0;
	}
}
