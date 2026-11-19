using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace System.Net.Security;

public class SslServerAuthenticationOptions
{
	private X509RevocationMode _checkCertificateRevocation;

	private SslProtocols _enabledSslProtocols;

	private EncryptionPolicy _encryptionPolicy;

	private bool _allowRenegotiation;

	public bool AllowRenegotiation => false;

	public bool ClientCertificateRequired { get; set; }

	public X509Certificate ServerCertificate { get; set; }

	public SslProtocols EnabledSslProtocols
	{
		get
		{
			return SslProtocols.None;
		}
		set
		{
		}
	}

	public X509RevocationMode CertificateRevocationCheckMode
	{
		set
		{
		}
	}

	public EncryptionPolicy EncryptionPolicy
	{
		set
		{
		}
	}
}
