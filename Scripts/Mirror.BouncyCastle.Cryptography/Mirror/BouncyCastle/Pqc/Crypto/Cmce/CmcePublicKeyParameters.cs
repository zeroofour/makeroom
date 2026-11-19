namespace Mirror.BouncyCastle.Pqc.Crypto.Cmce;

public sealed class CmcePublicKeyParameters : CmceKeyParameters
{
	internal readonly byte[] publicKey;

	public CmcePublicKeyParameters(CmceParameters parameters, byte[] publicKey)
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
