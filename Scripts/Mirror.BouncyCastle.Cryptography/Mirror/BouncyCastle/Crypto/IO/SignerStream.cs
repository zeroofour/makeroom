using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Mirror.BouncyCastle.Crypto.IO;

public sealed class SignerStream : Stream
{
	private readonly Stream m_stream;

	private readonly ISigner m_readSigner;

	private readonly ISigner m_writeSigner;

	public ISigner ReadSigner => null;

	public ISigner WriteSigner => null;

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

	private Stream ReadSource => null;

	public SignerStream(Stream stream, ISigner readSigner, ISigner writeSigner)
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

	public override void SetLength(long length)
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public override void WriteByte(byte value)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
