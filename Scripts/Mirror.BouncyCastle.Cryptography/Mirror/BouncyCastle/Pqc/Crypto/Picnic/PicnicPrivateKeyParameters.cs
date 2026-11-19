namespace Mirror.BouncyCastle.Pqc.Crypto.Picnic;

public sealed class PicnicPrivateKeyParameters : PicnicKeyParameters
{
	private readonly byte[] m_privateKey;

	public PicnicPrivateKeyParameters(PicnicParameters parameters, byte[] skEncoded)
		: base(isPrivate: false, null)
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}
}
