namespace Mirror.BouncyCastle.Crypto.Operators;

public sealed class DefaultSignatureResult : IBlockResult
{
	private readonly ISigner m_signer;

	public DefaultSignatureResult(ISigner signer)
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
