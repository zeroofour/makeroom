using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class ByteQueueInputStream : BaseInputStream
{
	private readonly ByteQueue m_buffer;

	public int Available => 0;

	public void AddBytes(byte[] buf)
	{
	}

	public void AddBytes(byte[] buf, int bufOff, int bufLen)
	{
	}

	public int Peek(byte[] buf)
	{
		return 0;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	public override int ReadByte()
	{
		return 0;
	}

	public long Skip(long n)
	{
		return 0L;
	}
}
