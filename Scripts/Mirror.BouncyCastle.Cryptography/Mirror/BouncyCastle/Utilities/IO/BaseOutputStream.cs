using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Mirror.BouncyCastle.Utilities.IO;

public abstract class BaseOutputStream : Stream
{
	public sealed override bool CanRead => false;

	public sealed override bool CanSeek => false;

	public sealed override bool CanWrite => false;

	public sealed override long Length => 0L;

	public sealed override long Position
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
	{
		return null;
	}

	public override void Flush()
	{
	}

	public sealed override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	public sealed override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	public sealed override void SetLength(long value)
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public virtual void Write(params byte[] buffer)
	{
	}
}
