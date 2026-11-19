using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public abstract class DefaultTlsServer : AbstractTlsServer
{
	private static readonly int[] DefaultCipherSuites;

	public DefaultTlsServer(TlsCrypto crypto)
		: base(null)
	{
	}

	protected virtual TlsCredentialedSigner GetDsaSignerCredentials()
	{
		return null;
	}

	protected virtual TlsCredentialedSigner GetECDsaSignerCredentials()
	{
		return null;
	}

	protected virtual TlsCredentialedDecryptor GetRsaEncryptionCredentials()
	{
		return null;
	}

	protected virtual TlsCredentialedSigner GetRsaSignerCredentials()
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
}
