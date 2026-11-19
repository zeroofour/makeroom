using System.Security.Cryptography.X509Certificates;

namespace System.Net;

public class ServicePoint
{
	private readonly Uri uri;

	private bool usesProxy;

	private bool sendContinue;

	private bool useConnect;

	private object hostE;

	private bool useNagle;

	private bool tcp_keepalive;

	private int tcp_keepalive_time;

	private int tcp_keepalive_interval;

	private int connectionLeaseTimeout;

	private int receiveBufferSize;

	private readonly ServicePointManager.SPKey Key;

	private int connectionLimit;

	private int maxIdleTime;

	private object m_ServerCertificateOrBytes;

	private ServicePointScheduler Scheduler { set; }

	public bool Expect100Continue
	{
		set
		{
		}
	}

	public bool UseNagleAlgorithm
	{
		set
		{
		}
	}

	internal bool SendContinue
	{
		set
		{
		}
	}

	internal bool UsesProxy
	{
		set
		{
		}
	}

	internal bool UseConnect
	{
		set
		{
		}
	}

	internal ServicePoint(ServicePointManager.SPKey key, Uri uri, int connectionLimit, int maxIdleTime)
	{
	}

	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval)
	{
	}

	internal void UpdateServerCertificate(X509Certificate certificate)
	{
	}
}
