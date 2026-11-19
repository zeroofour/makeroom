namespace Mirror.BouncyCastle.Pqc.Crypto.Frodo;

public sealed class FrodoPublicKeyParameters : FrodoKeyParameters
{
	internal readonly byte[] m_publicKey;

	public FrodoPublicKeyParameters(FrodoParameters parameters, byte[] publicKey)
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
