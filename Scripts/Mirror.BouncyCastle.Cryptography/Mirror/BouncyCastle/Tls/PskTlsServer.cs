using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class PskTlsServer : AbstractTlsServer
{
	private static readonly int[] DefaultCipherSuites;

	protected readonly TlsPskIdentityManager m_pskIdentityManager;

	public PskTlsServer(TlsCrypto crypto, TlsPskIdentityManager pskIdentityManager)
		: base(null)
	{
	}

	protected virtual TlsCredentialedDecryptor GetRsaEncryptionCredentials()
	{
		return null;
	}

	protected override ProtocolVersion[] GetSupportedVersions()
	{
		return null;
	}

	protected override int[] GetSupportedCipherSuites()
	{
		return null;
	}

	public override TlsCredentials GetCredentials()
	{
		return null;
	}

	public override TlsPskIdentityManager GetPskIdentityManager()
	{
		return null;
	}
}
