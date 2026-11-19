using System.Collections.Generic;
using System.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class CertificateUrl
{
	internal class ListBuffer16 : MemoryStream
	{
		internal ListBuffer16()
		{
		}

		internal void EncodeTo(Stream output)
		{
		}
	}

	private readonly short m_type;

	private readonly IList<UrlAndHash> m_urlAndHashList;

	public short Type => 0;

	public IList<UrlAndHash> UrlAndHashList => null;

	public CertificateUrl(short type, IList<UrlAndHash> urlAndHashList)
	{
	}

	public void Encode(Stream output)
	{
	}

	public static CertificateUrl Parse(TlsContext context, Stream input)
	{
		return null;
	}
}
