namespace Mirror.BouncyCastle.Crypto.Generators;

public sealed class Mgf1BytesGenerator : IDerivationFunction
{
	private readonly IDigest m_digest;

	private readonly int m_hLen;

	private byte[] m_buffer;

	public IDigest Digest => null;

	public Mgf1BytesGenerator(IDigest digest)
	{
	}

	public void Init(IDerivationParameters parameters)
	{
	}

	public int GenerateBytes(byte[] output, int outOff, int length)
	{
		return 0;
	}
}
