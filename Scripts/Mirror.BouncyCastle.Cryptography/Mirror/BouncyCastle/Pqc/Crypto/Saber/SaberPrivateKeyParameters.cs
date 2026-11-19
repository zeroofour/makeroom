namespace Mirror.BouncyCastle.Pqc.Crypto.Saber;

public sealed class SaberPrivateKeyParameters : SaberKeyParameters
{
	private readonly byte[] privateKey;

	public SaberPrivateKeyParameters(SaberParameters parameters, byte[] privateKey)
		: base(isPrivate: false, null)
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	public byte[] GetPrivateKey()
	{
		return null;
	}
}
