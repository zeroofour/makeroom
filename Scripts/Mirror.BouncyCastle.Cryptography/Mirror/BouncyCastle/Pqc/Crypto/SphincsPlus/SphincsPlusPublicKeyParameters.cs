namespace Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

public sealed class SphincsPlusPublicKeyParameters : SphincsPlusKeyParameters
{
	private readonly PK m_pk;

	public SphincsPlusPublicKeyParameters(SphincsPlusParameters parameters, byte[] pkEncoded)
		: base(isPrivate: false, null)
	{
	}

	internal SphincsPlusPublicKeyParameters(SphincsPlusParameters parameters, PK pk)
		: base(isPrivate: false, null)
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	public byte[] GetRoot()
	{
		return null;
	}

	public byte[] GetSeed()
	{
		return null;
	}
}
