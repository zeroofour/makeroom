namespace Mirror.BouncyCastle.Pqc.Crypto.NtruPrime;

public sealed class NtruLPRimePublicKeyParameters : NtruLPRimeKeyParameters
{
	internal byte[] pubKey;

	public NtruLPRimePublicKeyParameters(NtruLPRimeParameters primeParameters, byte[] pubKey)
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
