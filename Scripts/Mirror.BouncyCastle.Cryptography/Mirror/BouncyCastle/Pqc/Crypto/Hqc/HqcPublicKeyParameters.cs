namespace Mirror.BouncyCastle.Pqc.Crypto.Hqc;

public sealed class HqcPublicKeyParameters : HqcKeyParameters
{
	private byte[] pk;

	public byte[] PublicKey => null;

	public HqcPublicKeyParameters(HqcParameters param, byte[] pk)
		: base(isPrivate: false, null)
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}
}
