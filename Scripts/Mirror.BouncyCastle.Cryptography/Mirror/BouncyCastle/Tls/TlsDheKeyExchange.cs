using System.IO;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class TlsDheKeyExchange : AbstractTlsKeyExchange
{
	protected TlsDHGroupVerifier m_dhGroupVerifier;

	protected TlsDHConfig m_dhConfig;

	protected TlsCredentialedSigner m_serverCredentials;

	protected TlsCertificate m_serverCertificate;

	protected TlsAgreement m_agreement;

	public override bool RequiresServerKeyExchange => false;

	private static int CheckKeyExchange(int keyExchange)
	{
		return 0;
	}

	public TlsDheKeyExchange(int keyExchange, TlsDHGroupVerifier dhGroupVerifier)
		: base(0)
	{
	}

	public TlsDheKeyExchange(int keyExchange, TlsDHConfig dhConfig)
		: base(0)
	{
	}

	private TlsDheKeyExchange(int keyExchange, TlsDHGroupVerifier dhGroupVerifier, TlsDHConfig dhConfig)
		: base(0)
	{
	}

	public override void SkipServerCredentials()
	{
	}

	public override void ProcessServerCredentials(TlsCredentials serverCredentials)
	{
	}

	public override void ProcessServerCertificate(Certificate serverCertificate)
	{
	}

	public override byte[] GenerateServerKeyExchange()
	{
		return null;
	}

	public override void ProcessServerKeyExchange(Stream input)
	{
	}

	public override short[] GetClientCertificateTypes()
	{
		return null;
	}

	public override void ProcessClientCredentials(TlsCredentials clientCredentials)
	{
	}

	public override void GenerateClientKeyExchange(Stream output)
	{
	}

	public override void ProcessClientKeyExchange(Stream input)
	{
	}

	public override TlsSecret GeneratePreMasterSecret()
	{
		return null;
	}
}
