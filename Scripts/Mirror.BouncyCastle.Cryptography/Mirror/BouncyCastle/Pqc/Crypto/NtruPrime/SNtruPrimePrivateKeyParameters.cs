namespace Mirror.BouncyCastle.Pqc.Crypto.NtruPrime;

public sealed class SNtruPrimePrivateKeyParameters : SNtruPrimeKeyParameters
{
	internal byte[] privKey;

	public SNtruPrimePrivateKeyParameters(SNtruPrimeParameters primeParameters, byte[] privKey)
		: base(isPrivate: false, null)
	{
	}

	public byte[] GetPrivateKey()
	{
		return null;
	}

	public byte[] GetEncoded()
	{
		return null;
	}
}
