using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Tls.Crypto;

public class TlsMacSink : BaseOutputStream
{
	private readonly TlsMac m_mac;

	public virtual TlsMac Mac => null;

	public TlsMacSink(TlsMac mac)
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override void WriteByte(byte value)
	{
	}
}
