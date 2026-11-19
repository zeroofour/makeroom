namespace Mirror.BouncyCastle.Pqc.Crypto.NtruPrime;

public sealed class SNtruPrimePublicKeyParameters : SNtruPrimeKeyParameters
{
	internal byte[] pubKey;

	public SNtruPrimePublicKeyParameters(SNtruPrimeParameters primeParameters, byte[] pubKey)
		: base(isPrivate: false, null)
	{
	}

	public byte[] GetPublicKey()
	{
		return null;
	}

	public byte[] GetEncoded()
	{
		return null;
	}
}
