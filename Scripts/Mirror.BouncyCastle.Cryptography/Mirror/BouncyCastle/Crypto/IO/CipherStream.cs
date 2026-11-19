using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Mirror.BouncyCastle.Crypto.IO;

public sealed class CipherStream : Stream
{
	private readonly Stream m_stream;

	private readonly IBufferedCipher m_readCipher;

	private readonly IBufferedCipher m_writeCipher;

	private byte[] m_readBuf;

	private int m_readBufPos;

	private bool m_readEnded;

	public IBufferedCipher ReadCipher => null;

	public IBufferedCipher WriteCipher => null;

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

	public CipherStream(Stream stream, IBufferedCipher readCipher, IBufferedCipher writeCipher)
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

	private bool FillInBuf()
	{
		return false;
	}

	private byte[] ReadAndProcessBlock()
	{
		return null;
	}
}
