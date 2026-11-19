using System.IO;

namespace Mirror.BouncyCastle.Cms;

public class CmsTypedStream
{
	private readonly string m_oid;

	private readonly Stream m_in;

	public string ContentType => null;

	public Stream ContentStream => null;

	public CmsTypedStream(Stream inStream)
	{
	}

	public CmsTypedStream(string oid, Stream inStream)
	{
	}

	public CmsTypedStream(string oid, Stream inStream, int bufSize)
	{
	}

	public void Drain()
	{
	}
}
