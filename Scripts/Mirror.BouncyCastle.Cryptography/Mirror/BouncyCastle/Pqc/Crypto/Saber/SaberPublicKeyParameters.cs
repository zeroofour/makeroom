namespace Mirror.BouncyCastle.Pqc.Crypto.Saber;

public sealed class SaberPublicKeyParameters : SaberKeyParameters
{
	public readonly byte[] publicKey;

	public SaberPublicKeyParameters(SaberParameters parameters, byte[] publicKey)
		: base(isPrivate: false, null)
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	public byte[] GetPublicKey()
	{
		return null;
	}
}
