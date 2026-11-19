using System.IO;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Utilities.Zlib;

public class ZInputStream : BaseInputStream
{
	private const int BufferSize = 4096;

	protected ZStream z;

	protected int flushLevel;

	protected byte[] buf;

	protected byte[] buf1;

	protected bool compress;

	protected Stream input;

	protected bool closed;

	private bool nomoreinput;

	public virtual int FlushMode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual long TotalIn => 0L;

	public virtual long TotalOut => 0L;

	private static ZStream GetDefaultZStream(bool nowrap)
	{
		return null;
	}

	public ZInputStream(Stream input)
	{
	}

	public ZInputStream(Stream input, bool nowrap)
	{
	}

	public ZInputStream(Stream input, ZStream z)
	{
	}

	public ZInputStream(Stream input, int level)
	{
	}

	public ZInputStream(Stream input, int level, bool nowrap)
	{
	}

	protected void Detach(bool disposing)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	private void ImplDisposing(bool disposeInput)
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
