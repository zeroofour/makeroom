using System.IO;

namespace Mirror.BouncyCastle.Utilities.Bzip2;

public class CBZip2InputStreamLeaveOpen : CBZip2InputStream
{
	public CBZip2InputStreamLeaveOpen(Stream outStream)
		: base(null)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
