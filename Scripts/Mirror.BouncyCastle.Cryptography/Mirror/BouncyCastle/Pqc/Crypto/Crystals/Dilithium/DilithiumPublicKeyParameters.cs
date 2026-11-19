namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;

public sealed class DilithiumPublicKeyParameters : DilithiumKeyParameters
{
	internal readonly byte[] m_rho;

	internal readonly byte[] m_t1;

	internal static byte[] GetEncoded(byte[] rho, byte[] t1)
	{
		return null;
	}

	public DilithiumPublicKeyParameters(DilithiumParameters parameters, byte[] rho, byte[] t1)
		: base(isPrivate: false, null)
	{
	}

	public DilithiumPublicKeyParameters(DilithiumParameters parameters, byte[] pkEncoded)
		: base(isPrivate: false, null)
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	public byte[] GetRho()
	{
		return null;
	}

	public byte[] GetT1()
	{
		return null;
	}
}
