using System.IO;

namespace Mirror.BouncyCastle.Utilities.IO;

internal sealed class LimitedInputStream : BaseInputStream
{
	private readonly Stream m_stream;

	private long m_limit;

	internal long CurrentLimit => 0L;

	internal LimitedInputStream(Stream stream, long limit)
	{
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	public override int ReadByte()
	{
		return 0;
	}
}
