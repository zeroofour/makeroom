namespace Mirror.BouncyCastle.Utilities.IO;

public sealed class LimitedBuffer : BaseOutputStream
{
	private readonly byte[] m_buf;

	private int m_count;

	public int Count => 0;

	public int Limit => 0;

	public LimitedBuffer(int limit)
	{
	}

	public int CopyTo(byte[] buffer, int offset)
	{
		return 0;
	}

	public void Reset()
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override void WriteByte(byte value)
	{
	}
}
