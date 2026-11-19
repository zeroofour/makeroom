namespace Mirror.BouncyCastle.Crypto;

public sealed class SimpleBlockResult : IBlockResult
{
	private readonly byte[] result;

	public SimpleBlockResult(byte[] result)
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
