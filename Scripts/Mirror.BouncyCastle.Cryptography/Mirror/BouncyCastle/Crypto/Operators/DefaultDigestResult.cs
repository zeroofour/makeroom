namespace Mirror.BouncyCastle.Crypto.Operators;

public sealed class DefaultDigestResult : IBlockResult
{
	private readonly IDigest m_digest;

	public DefaultDigestResult(IDigest digest)
	{
	}

	public byte[] Collect()
	{
		return null;
	}

	public int Collect(byte[] buf, int off)
	{
		return 0;
	}

	public int GetMaxResultLength()
	{
		return 0;
	}
}
