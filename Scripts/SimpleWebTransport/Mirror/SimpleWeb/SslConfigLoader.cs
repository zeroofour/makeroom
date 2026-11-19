using System.Security.Authentication;

namespace Mirror.SimpleWeb;

public class SslConfigLoader
{
	internal struct Cert
	{
		public string path;

		public string password;
	}

	public static SslConfig Load(bool sslEnabled, string sslCertJson, SslProtocols sslProtocols)
	{
		return default;
	}

	internal static Cert LoadCertJson(string certJsonPath)
	{
		return default;
	}
}
