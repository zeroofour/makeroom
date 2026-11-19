using System.IO;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

internal class DigestInputBuffer : MemoryStream
{
	internal void UpdateDigest(TlsHash hash)
	{
	}

	internal void CopyInputTo(Stream output)
	{
	}
}
