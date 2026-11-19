using System.Collections.Concurrent;

namespace System.Net;

public class ServicePointManager
{
	internal class SPKey
	{
		private Uri uri;

		private Uri proxy;

		private bool use_connect;

		public bool UsesProxy => false;

		public SPKey(Uri uri, Uri proxy, bool use_connect)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}

	private static ConcurrentDictionary<SPKey, ServicePoint> servicePoints;

	private static ICertificatePolicy policy;

	private static int defaultConnectionLimit;

	private static int maxServicePointIdleTime;

	private static int maxServicePoints;

	private static int dnsRefreshTimeout;

	private static bool _checkCRL;

	private static SecurityProtocolType _securityProtocol;

	private static bool expectContinue;

	private static bool useNagle;

	private static ServerCertValidationCallback server_cert_cb;

	private static bool tcp_keepalive;

	private static int tcp_keepalive_time;

	private static int tcp_keepalive_interval;

	[MonoTODO("CRL checks not implemented")]
	public static bool CheckCertificateRevocationList => false;

	internal static ServerCertValidationCallback ServerCertValidationCallback => null;

	static ServicePointManager()
	{
	}

	internal static ICertificatePolicy GetLegacyCertificatePolicy()
	{
		return null;
	}

	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy)
	{
		return null;
	}
}
