using Mirror.BouncyCastle.Pqc.Crypto.Ntru.ParameterSets;
using Mirror.BouncyCastle.Pqc.Crypto.Ntru.Polynomials;

namespace Mirror.BouncyCastle.Pqc.Crypto.Ntru.Owcpa;

internal class NtruOwcpa
{
	private readonly NtruParameterSet _parameterSet;

	private readonly NtruSampling _sampling;

	internal NtruOwcpa(NtruParameterSet parameterSet)
	{
	}

	internal OwcpaKeyPair KeyPair(byte[] seed)
	{
		return null;
	}

	internal byte[] Encrypt(Polynomial r, Polynomial m, byte[] publicKey)
	{
		return null;
	}

	internal OwcpaDecryptResult Decrypt(byte[] ciphertext, byte[] privateKey)
	{
		return null;
	}

	private int CheckCiphertext(byte[] ciphertext)
	{
		return 0;
	}

	private int CheckR(Polynomial r)
	{
		return 0;
	}

	private int CheckM(HpsPolynomial m)
	{
		return 0;
	}
}
