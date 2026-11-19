using System.IO;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class TlsRsaKeyExchange : AbstractTlsKeyExchange
{
	protected TlsCredentialedDecryptor m_serverCredentials;

	protected TlsEncryptor m_serverEncryptor;

	protected TlsSecret m_preMasterSecret;

	private static int CheckKeyExchange(int keyExchange)
	{
		return 0;
	}

	public TlsRsaKeyExchange(int keyExchange)
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
