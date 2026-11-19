using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Mirror.BouncyCastle.Utilities.IO;

public class FilterStream : Stream
{
	protected readonly Stream s;

	public override bool CanRead => false;

	public override bool CanSeek => false;

	public override bool CanWrite => false;

	public override long Length => 0L;

	public override long Position
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public FilterStream(Stream s)
	{
	}

	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
	{
		return null;
	}

	public override void Flush()
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

	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	public override void SetLength(long value)
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override void WriteByte(byte value)
	{
	}

	protected void Detach(bool disposing)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
