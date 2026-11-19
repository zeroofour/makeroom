using System.IO;

namespace Mirror.BouncyCastle.Utilities.IO;

internal sealed class BufferedFilterStream : FilterStream
{
	internal BufferedFilterStream(Stream s)
		: base(null)
	{
	}

	internal BufferedFilterStream(Stream s, int bufferSize)
		: base(null)
	{
	}
}
