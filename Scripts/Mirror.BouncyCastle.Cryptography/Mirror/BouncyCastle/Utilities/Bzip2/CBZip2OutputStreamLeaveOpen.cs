using System.IO;

namespace Mirror.BouncyCastle.Utilities.Bzip2;

public class CBZip2OutputStreamLeaveOpen : CBZip2OutputStream
{
	public CBZip2OutputStreamLeaveOpen(Stream outStream)
		: base(null)
	{
	}

	public CBZip2OutputStreamLeaveOpen(Stream outStream, int blockSize)
		: base(null)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
