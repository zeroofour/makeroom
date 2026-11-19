namespace Mirror.BouncyCastle.Tls;

public class DefaultTlsHeartbeat : TlsHeartbeat
{
	private readonly int idleMillis;

	private readonly int timeoutMillis;

	private uint counter;

	public virtual int IdleMillis => 0;

	public virtual int TimeoutMillis => 0;

	public DefaultTlsHeartbeat(int idleMillis, int timeoutMillis)
	{
	}

	public virtual byte[] GeneratePayload()
	{
		return null;
	}
}
