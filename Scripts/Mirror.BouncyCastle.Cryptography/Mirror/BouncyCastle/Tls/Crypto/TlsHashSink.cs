using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Tls.Crypto;

public class TlsHashSink : BaseOutputStream
{
	private readonly TlsHash m_hash;

	public virtual TlsHash Hash => null;

	public TlsHashSink(TlsHash hash)
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override void WriteByte(byte value)
	{
	}
}
