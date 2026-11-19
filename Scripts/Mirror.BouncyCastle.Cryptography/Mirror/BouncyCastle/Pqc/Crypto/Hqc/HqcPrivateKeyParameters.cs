namespace Mirror.BouncyCastle.Pqc.Crypto.Hqc;

public sealed class HqcPrivateKeyParameters : HqcKeyParameters
{
	private byte[] sk;

	public byte[] PrivateKey => null;

	public HqcPrivateKeyParameters(HqcParameters param, byte[] sk)
		: base(isPrivate: false, null)
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}
}
