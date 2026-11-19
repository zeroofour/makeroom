namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Kyber;

public sealed class KyberPublicKeyParameters : KyberKeyParameters
{
	private readonly byte[] m_t;

	private readonly byte[] m_rho;

	internal static byte[] GetEncoded(byte[] t, byte[] rho)
	{
		return null;
	}

	public KyberPublicKeyParameters(KyberParameters parameters, byte[] t, byte[] rho)
		: base(isPrivate: false, null)
	{
	}

	public KyberPublicKeyParameters(KyberParameters parameters, byte[] encoding)
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

	public byte[] GetT()
	{
		return null;
	}
}
