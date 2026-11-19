using System.IO;

namespace Mirror.BouncyCastle.Utilities.Zlib;

public class ZInputStreamLeaveOpen : ZInputStream
{
	public ZInputStreamLeaveOpen(Stream input)
		: base(null)
	{
	}

	public ZInputStreamLeaveOpen(Stream input, bool nowrap)
		: base(null)
	{
	}

	public ZInputStreamLeaveOpen(Stream input, ZStream z)
		: base(null)
	{
	}

	public ZInputStreamLeaveOpen(Stream input, int level)
		: base(null)
	{
	}

	public ZInputStreamLeaveOpen(Stream input, int level, bool nowrap)
		: base(null)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
