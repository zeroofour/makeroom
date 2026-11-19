using System.IO;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public abstract class AbstractTlsKeyExchange : TlsKeyExchange
{
	protected readonly int m_keyExchange;

	protected TlsContext m_context;

	public virtual bool RequiresServerKeyExchange => false;

	public virtual bool RequiresCertificateVerify => false;

	protected AbstractTlsKeyExchange(int keyExchange)
	{
	}

	public virtual void Init(TlsContext context)
	{
	}

	public abstract void SkipServerCredentials();

	public abstract void ProcessServerCredentials(TlsCredentials serverCredentials);

	public virtual void ProcessServerCertificate(Certificate serverCertificate)
	{
	}

	public virtual byte[] GenerateServerKeyExchange()
	{
		return null;
	}

	public virtual void SkipServerKeyExchange()
	{
	}

	public virtual void ProcessServerKeyExchange(Stream input)
	{
	}

	public virtual short[] GetClientCertificateTypes()
	{
		return null;
	}

	public virtual void SkipClientCredentials()
	{
	}

	public abstract void ProcessClientCredentials(TlsCredentials clientCredentials);

	public virtual void ProcessClientCertificate(Certificate clientCertificate)
	{
	}

	public abstract void GenerateClientKeyExchange(Stream output);

	public virtual void ProcessClientKeyExchange(Stream input)
	{
	}

	public abstract TlsSecret GeneratePreMasterSecret();
}
