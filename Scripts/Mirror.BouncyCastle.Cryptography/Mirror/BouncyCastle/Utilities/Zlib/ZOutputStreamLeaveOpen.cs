using System.IO;

namespace Mirror.BouncyCastle.Utilities.Zlib;

public class ZOutputStreamLeaveOpen : ZOutputStream
{
	public ZOutputStreamLeaveOpen(Stream output)
		: base(null)
	{
	}

	public ZOutputStreamLeaveOpen(Stream output, bool nowrap)
		: base(null)
	{
	}

	public ZOutputStreamLeaveOpen(Stream output, ZStream z)
		: base(null)
	{
	}

	public ZOutputStreamLeaveOpen(Stream output, int level)
		: base(null)
	{
	}

	public ZOutputStreamLeaveOpen(Stream output, int level, bool nowrap)
		: base(null)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
