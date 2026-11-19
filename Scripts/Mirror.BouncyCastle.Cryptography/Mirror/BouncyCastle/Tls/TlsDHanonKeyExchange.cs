using System.IO;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class TlsDHanonKeyExchange : AbstractTlsKeyExchange
{
	protected TlsDHGroupVerifier m_dhGroupVerifier;

	protected TlsDHConfig m_dhConfig;

	protected TlsAgreement m_agreement;

	public override bool RequiresServerKeyExchange => false;

	private static int CheckKeyExchange(int keyExchange)
	{
		return 0;
	}

	public TlsDHanonKeyExchange(int keyExchange, TlsDHGroupVerifier dhGroupVerifier)
		: base(0)
	{
	}

	public TlsDHanonKeyExchange(int keyExchange, TlsDHConfig dhConfig)
		: base(0)
	{
	}

	private TlsDHanonKeyExchange(int keyExchange, TlsDHGroupVerifier dhGroupVerifier, TlsDHConfig dhConfig)
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

	public override void ProcessClientCertificate(Certificate clientCertificate)
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
