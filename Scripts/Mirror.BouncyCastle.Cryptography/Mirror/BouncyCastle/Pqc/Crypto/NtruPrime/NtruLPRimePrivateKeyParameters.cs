namespace Mirror.BouncyCastle.Pqc.Crypto.NtruPrime;

public sealed class NtruLPRimePrivateKeyParameters : NtruLPRimeKeyParameters
{
	internal byte[] privKey;

	public NtruLPRimePrivateKeyParameters(NtruLPRimeParameters primeParameters, byte[] privKey)
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
