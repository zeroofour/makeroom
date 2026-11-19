namespace Mirror.BouncyCastle.Pqc.Crypto.Cmce;

public sealed class CmcePrivateKeyParameters : CmceKeyParameters
{
	internal readonly byte[] privateKey;

	internal byte[] Delta => null;

	internal byte[] C => null;

	internal byte[] G => null;

	internal byte[] Alpha => null;

	internal byte[] S => null;

	public byte[] GetPrivateKey()
	{
		return null;
	}

	public CmcePrivateKeyParameters(CmceParameters parameters, byte[] privateKey)
		: base(isPrivate: false, null)
	{
	}

	public CmcePrivateKeyParameters(CmceParameters parameters, byte[] delta, byte[] C, byte[] g, byte[] alpha, byte[] s)
		: base(isPrivate: false, null)
	{
	}

	public byte[] ReconstructPublicKey()
	{
		return null;
	}

	public byte[] GetEncoded()
	{
		return null;
	}
}
