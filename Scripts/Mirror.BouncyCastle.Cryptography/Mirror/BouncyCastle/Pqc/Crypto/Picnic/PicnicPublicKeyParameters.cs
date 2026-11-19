namespace Mirror.BouncyCastle.Pqc.Crypto.Picnic;

public sealed class PicnicPublicKeyParameters : PicnicKeyParameters
{
	private readonly byte[] m_publicKey;

	public PicnicPublicKeyParameters(PicnicParameters parameters, byte[] pkEncoded)
		: base(isPrivate: false, null)
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}
}
