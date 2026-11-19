using System.IO;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class TlsDHKeyExchange : AbstractTlsKeyExchange
{
	protected TlsCredentialedAgreement m_agreementCredentials;

	protected TlsCertificate m_dhPeerCertificate;

	public override bool RequiresCertificateVerify => false;

	private static int CheckKeyExchange(int keyExchange)
	{
		return 0;
	}

	public TlsDHKeyExchange(int keyExchange)
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

	public override short[] GetClientCertificateTypes()
	{
		return null;
	}

	public override void SkipClientCredentials()
	{
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
