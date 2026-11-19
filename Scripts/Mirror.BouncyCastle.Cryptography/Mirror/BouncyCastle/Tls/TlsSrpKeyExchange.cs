using System.IO;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class TlsSrpKeyExchange : AbstractTlsKeyExchange
{
	protected TlsSrpIdentity m_srpIdentity;

	protected TlsSrpConfigVerifier m_srpConfigVerifier;

	protected TlsCertificate m_serverCertificate;

	protected byte[] m_srpSalt;

	protected TlsSrp6Client m_srpClient;

	protected TlsSrpLoginParameters m_srpLoginParameters;

	protected TlsCredentialedSigner m_serverCredentials;

	protected TlsSrp6Server m_srpServer;

	protected BigInteger m_srpPeerCredentials;

	public override bool RequiresServerKeyExchange => false;

	private static int CheckKeyExchange(int keyExchange)
	{
		return 0;
	}

	public TlsSrpKeyExchange(int keyExchange, TlsSrpIdentity srpIdentity, TlsSrpConfigVerifier srpConfigVerifier)
		: base(0)
	{
	}

	public TlsSrpKeyExchange(int keyExchange, TlsSrpLoginParameters srpLoginParameters)
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

	protected static BigInteger ValidatePublicValue(BigInteger N, BigInteger val)
	{
		return null;
	}
}
