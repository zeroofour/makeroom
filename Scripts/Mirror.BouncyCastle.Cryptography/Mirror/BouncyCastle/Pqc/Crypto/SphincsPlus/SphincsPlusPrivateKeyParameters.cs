namespace Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

public sealed class SphincsPlusPrivateKeyParameters : SphincsPlusKeyParameters
{
	internal readonly SK m_sk;

	internal readonly PK m_pk;

	public SphincsPlusPrivateKeyParameters(SphincsPlusParameters parameters, byte[] skpkEncoded)
		: base(isPrivate: false, null)
	{
	}

	public SphincsPlusPrivateKeyParameters(SphincsPlusParameters parameters, byte[] skSeed, byte[] prf, byte[] pkSeed, byte[] pkRoot)
		: base(isPrivate: false, null)
	{
	}

	internal SphincsPlusPrivateKeyParameters(SphincsPlusParameters parameters, SK sk, PK pk)
		: base(isPrivate: false, null)
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	public byte[] GetEncodedPublicKey()
	{
		return null;
	}

	public byte[] GetPrf()
	{
		return null;
	}

	public byte[] GetPublicKey()
	{
		return null;
	}

	public byte[] GetPublicSeed()
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
