using System.Security.Authentication;

namespace Mirror.SimpleWeb;

public struct SslConfig(bool enabled, string certPath, string certPassword, SslProtocols sslProtocols)
{
	public readonly bool enabled = false;

	public readonly string certPath = null;

	public readonly string certPassword = null;

	public readonly SslProtocols sslProtocols = SslProtocols.None;
}
