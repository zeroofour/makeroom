using System.IO;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class TlsPskKeyExchange : AbstractTlsKeyExchange
{
	protected TlsPskIdentity m_pskIdentity;

	protected TlsPskIdentityManager m_pskIdentityManager;

	protected TlsDHGroupVerifier m_dhGroupVerifier;

	protected byte[] m_psk_identity_hint;

	protected byte[] m_psk;

	protected TlsDHConfig m_dhConfig;

	protected TlsECConfig m_ecConfig;

	protected TlsAgreement m_agreement;

	protected TlsCredentialedDecryptor m_serverCredentials;

	protected TlsEncryptor m_serverEncryptor;

	protected TlsSecret m_preMasterSecret;

	public override bool RequiresServerKeyExchange => false;

	private static int CheckKeyExchange(int keyExchange)
	{
		return 0;
	}

	public TlsPskKeyExchange(int keyExchange, TlsPskIdentity pskIdentity, TlsDHGroupVerifier dhGroupVerifier)
		: base(0)
	{
	}

	public TlsPskKeyExchange(int keyExchange, TlsPskIdentityManager pskIdentityManager, TlsDHConfig dhConfig, TlsECConfig ecConfig)
		: base(0)
	{
	}

	private TlsPskKeyExchange(int keyExchange, TlsPskIdentity pskIdentity, TlsPskIdentityManager pskIdentityManager, TlsDHGroupVerifier dhGroupVerifier, TlsDHConfig dhConfig, TlsECConfig ecConfig)
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

	protected virtual void GenerateEphemeralDH(Stream output)
	{
	}

	protected virtual void GenerateEphemeralECDH(Stream output)
	{
	}

	protected virtual byte[] GenerateOtherSecret(int pskLength)
	{
		return null;
	}

	protected virtual void ProcessEphemeralDH(byte[] y)
	{
	}

	protected virtual void ProcessEphemeralECDH(byte[] point)
	{
	}
}
