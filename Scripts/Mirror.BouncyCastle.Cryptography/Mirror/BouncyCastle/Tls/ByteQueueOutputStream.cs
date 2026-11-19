using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class ByteQueueOutputStream : BaseOutputStream
{
	private readonly ByteQueue m_buffer;

	public ByteQueue Buffer => null;

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override void WriteByte(byte value)
	{
	}
}
