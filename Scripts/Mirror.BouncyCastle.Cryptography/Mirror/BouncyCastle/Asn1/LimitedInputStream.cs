using System.IO;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Asn1;

internal abstract class LimitedInputStream : BaseInputStream
{
	protected readonly Stream _in;

	private int _limit;

	internal virtual int Limit => 0;

	internal LimitedInputStream(Stream inStream, int limit)
	{
	}

	protected void SetParentEofDetect()
	{
	}
}
