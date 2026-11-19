namespace Mirror.BouncyCastle.Crypto.Operators;

public sealed class DefaultMacResult : IBlockResult
{
	private readonly IMac m_mac;

	public DefaultMacResult(IMac mac)
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
