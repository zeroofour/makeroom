namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Kyber;

public sealed class KyberPrivateKeyParameters : KyberKeyParameters
{
	private readonly byte[] m_s;

	private readonly byte[] m_hpk;

	private readonly byte[] m_nonce;

	private readonly byte[] m_t;

	private readonly byte[] m_rho;

	public KyberPrivateKeyParameters(KyberParameters parameters, byte[] s, byte[] hpk, byte[] nonce, byte[] t, byte[] rho)
		: base(isPrivate: false, null)
	{
	}

	public KyberPrivateKeyParameters(KyberParameters parameters, byte[] encoding)
		: base(isPrivate: false, null)
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	public byte[] GetHpk()
	{
		return null;
	}

	public byte[] GetNonce()
	{
		return null;
	}

	public byte[] GetPublicKey()
	{
		return null;
	}

	public KyberPublicKeyParameters GetPublicKeyParameters()
	{
		return null;
	}

	public byte[] GetRho()
	{
		return null;
	}

	public byte[] GetS()
	{
		return null;
	}

	public byte[] GetT()
	{
		return null;
	}
}
