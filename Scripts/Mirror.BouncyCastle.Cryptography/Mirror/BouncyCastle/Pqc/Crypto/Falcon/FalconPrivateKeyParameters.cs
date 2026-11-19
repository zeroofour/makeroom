namespace Mirror.BouncyCastle.Pqc.Crypto.Falcon;

public sealed class FalconPrivateKeyParameters : FalconKeyParameters
{
	private readonly byte[] pk;

	private readonly byte[] f;

	private readonly byte[] g;

	private readonly byte[] F;

	public FalconPrivateKeyParameters(FalconParameters parameters, byte[] f, byte[] g, byte[] F, byte[] pk_encoded)
		: base(isprivate: false, null)
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

	public byte[] GetSpolyLittleF()
	{
		return null;
	}

	public byte[] GetG()
	{
		return null;
	}

	public byte[] GetSpolyBigF()
	{
		return null;
	}
}
