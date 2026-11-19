using System.IO;

namespace Mirror.BouncyCastle.Utilities.IO;

public class TeeInputStream : BaseInputStream
{
	private readonly Stream input;

	private readonly Stream tee;

	public TeeInputStream(Stream input, Stream tee)
	{
	}

	protected override void Dispose(bool disposing)
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
