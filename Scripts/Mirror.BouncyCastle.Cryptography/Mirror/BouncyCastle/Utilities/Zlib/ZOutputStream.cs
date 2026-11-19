using System.IO;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Utilities.Zlib;

public class ZOutputStream : BaseOutputStream
{
	private const int BufferSize = 4096;

	protected ZStream z;

	protected int flushLevel;

	protected byte[] buf;

	protected byte[] buf1;

	protected bool compress;

	protected Stream output;

	protected bool closed;

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

	public ZOutputStream(Stream output)
	{
	}

	public ZOutputStream(Stream output, bool nowrap)
	{
	}

	public ZOutputStream(Stream output, ZStream z)
	{
	}

	public ZOutputStream(Stream output, int level)
	{
	}

	public ZOutputStream(Stream output, int level, bool nowrap)
	{
	}

	protected void Detach(bool disposing)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	private void ImplDisposing(bool disposeOutput)
	{
	}

	public virtual void End()
	{
	}

	public virtual void Finish()
	{
	}

	public override void Flush()
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override void WriteByte(byte value)
	{
	}
}
