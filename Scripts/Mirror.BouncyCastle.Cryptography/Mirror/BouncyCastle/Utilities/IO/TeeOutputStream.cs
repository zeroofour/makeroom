using System.IO;

namespace Mirror.BouncyCastle.Utilities.IO;

public class TeeOutputStream : BaseOutputStream
{
	private readonly Stream output;

	private readonly Stream tee;

	public TeeOutputStream(Stream output, Stream tee)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override void WriteByte(byte value)
	{
	}
}
