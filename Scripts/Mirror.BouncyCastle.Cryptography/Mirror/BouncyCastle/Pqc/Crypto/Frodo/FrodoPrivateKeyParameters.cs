namespace Mirror.BouncyCastle.Pqc.Crypto.Frodo;

public sealed class FrodoPrivateKeyParameters : FrodoKeyParameters
{
	internal readonly byte[] privateKey;

	public FrodoPrivateKeyParameters(FrodoParameters parameters, byte[] privateKey)
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
