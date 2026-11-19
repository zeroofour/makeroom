namespace Mirror.BouncyCastle.Pqc.Crypto.Falcon;

public sealed class FalconPublicKeyParameters : FalconKeyParameters
{
	private readonly byte[] publicKey;

	public FalconPublicKeyParameters(FalconParameters parameters, byte[] h)
		: base(isprivate: false, null)
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}
}
