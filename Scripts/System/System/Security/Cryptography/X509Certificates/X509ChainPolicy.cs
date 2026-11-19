namespace System.Security.Cryptography.X509Certificates;

public sealed class X509ChainPolicy
{
	private OidCollection apps;

	private OidCollection cert;

	private X509CertificateCollection store;

	private X509Certificate2Collection store2;

	private X509RevocationFlag rflag;

	private X509RevocationMode mode;

	private TimeSpan timeout;

	private X509VerificationFlags vflags;

	private DateTime vtime;

	public X509Certificate2Collection ExtraStore
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public X509RevocationFlag RevocationFlag => X509RevocationFlag.EndCertificateOnly;

	public X509RevocationMode RevocationMode
	{
		get
		{
			return X509RevocationMode.NoCheck;
		}
		set
		{
		}
	}

	public X509VerificationFlags VerificationFlags
	{
		get
		{
			return X509VerificationFlags.NoFlag;
		}
		set
		{
		}
	}

	public DateTime VerificationTime => default;

	public void Reset()
	{
	}
}
