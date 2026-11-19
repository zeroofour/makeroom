namespace Mirror.BouncyCastle.Crypto.Agreement.Kdf;

public sealed class ConcatenationKdfGenerator : IDerivationFunction
{
	private readonly IDigest m_digest;

	private readonly int m_hLen;

	private byte[] m_buffer;

	public IDigest Digest => null;

	public ConcatenationKdfGenerator(IDigest digest)
	{
	}

	public void Init(IDerivationParameters param)
	{
	}

	public int GenerateBytes(byte[] output, int outOff, int length)
	{
		return 0;
	}
}
