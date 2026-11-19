using System.Net;
using System.Net.Security;

namespace Mono.Net.Security;

internal class MonoTlsStream
{
	private readonly HttpWebRequest request;

	private SslStream sslStream;

	private readonly object sslStreamLock;

	internal HttpWebRequest Request => null;

	internal bool CertificateValidationFailed { set; }

	public void Dispose()
	{
	}

	private void CloseSslStream()
	{
	}
}
