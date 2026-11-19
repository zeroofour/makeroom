using System.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class UrlAndHash
{
	private readonly string m_url;

	private readonly byte[] m_sha1Hash;

	public string Url => null;

	public byte[] Sha1Hash => null;

	public UrlAndHash(string url, byte[] sha1Hash)
	{
	}

	public void Encode(Stream output)
	{
	}

	public static UrlAndHash Parse(TlsContext context, Stream input)
	{
		return null;
	}
}
