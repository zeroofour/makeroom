using System.Collections.Generic;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class SrpTlsServer : AbstractTlsServer
{
	private static readonly int[] DefaultCipherSuites;

	protected readonly TlsSrpIdentityManager m_srpIdentityManager;

	protected byte[] m_srpIdentity;

	protected TlsSrpLoginParameters m_srpLoginParameters;

	public SrpTlsServer(TlsCrypto crypto, TlsSrpIdentityManager srpIdentityManager)
		: base(null)
	{
	}

	protected virtual TlsCredentialedSigner GetDsaSignerCredentials()
	{
		return null;
	}

	protected virtual TlsCredentialedSigner GetRsaSignerCredentials()
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

	public override void ProcessClientExtensions(IDictionary<int, byte[]> clientExtensions)
	{
	}

	public override int GetSelectedCipherSuite()
	{
		return 0;
	}

	public override TlsCredentials GetCredentials()
	{
		return null;
	}

	public override TlsSrpLoginParameters GetSrpLoginParameters()
	{
		return null;
	}
}
