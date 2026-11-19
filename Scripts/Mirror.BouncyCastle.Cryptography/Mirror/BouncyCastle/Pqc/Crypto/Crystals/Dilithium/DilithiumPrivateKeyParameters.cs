namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;

public sealed class DilithiumPrivateKeyParameters : DilithiumKeyParameters
{
	internal byte[] m_rho;

	internal byte[] m_k;

	internal byte[] m_tr;

	internal byte[] m_s1;

	internal byte[] m_s2;

	internal byte[] m_t0;

	private byte[] m_t1;

	public byte[] K => null;

	public byte[] Rho => null;

	public byte[] S1 => null;

	public byte[] S2 => null;

	public byte[] T0 => null;

	public byte[] T1 => null;

	public byte[] Tr => null;

	public DilithiumPrivateKeyParameters(DilithiumParameters parameters, byte[] rho, byte[] K, byte[] tr, byte[] s1, byte[] s2, byte[] t0, byte[] t1)
		: base(isPrivate: false, null)
	{
	}

	public DilithiumPrivateKeyParameters(DilithiumParameters parameters, byte[] encoding, DilithiumPublicKeyParameters pubKey)
		: base(isPrivate: false, null)
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

	public DilithiumPublicKeyParameters GetPublicKeyParameters()
	{
		return null;
	}
}
