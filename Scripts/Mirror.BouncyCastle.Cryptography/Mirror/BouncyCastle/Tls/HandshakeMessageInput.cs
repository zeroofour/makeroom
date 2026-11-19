using System.IO;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public sealed class HandshakeMessageInput : MemoryStream
{
	private readonly int m_offset;

	internal HandshakeMessageInput(byte[] buf, int offset, int length)
	{
	}

	public void UpdateHash(TlsHash hash)
	{
	}

	internal void UpdateHashPrefix(TlsHash hash, int bindersSize)
	{
	}

	internal void UpdateHashSuffix(TlsHash hash, int bindersSize)
	{
	}
}
