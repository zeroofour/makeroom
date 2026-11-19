namespace Mirror.BouncyCastle.Crypto.Parameters;

public class KdfParameters : IDerivationParameters
{
	private readonly byte[] m_iv;

	private readonly byte[] m_shared;

	public KdfParameters(byte[] shared, byte[] iv)
	{
	}

	public byte[] GetSharedSecret()
	{
		return null;
	}

	public byte[] GetIV()
	{
		return null;
	}
}
