using System.Collections.Generic;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class SrpTlsClient : AbstractTlsClient
{
	private static readonly int[] DefaultCipherSuites;

	protected readonly TlsSrpIdentity m_srpIdentity;

	protected virtual bool RequireSrpServerExtension => false;

	public SrpTlsClient(TlsCrypto crypto, byte[] identity, byte[] password)
		: base(null)
	{
	}

	public SrpTlsClient(TlsCrypto crypto, TlsSrpIdentity srpIdentity)
		: base(null)
	{
	}

	protected override int[] GetSupportedCipherSuites()
	{
		return null;
	}

	protected override ProtocolVersion[] GetSupportedVersions()
	{
		return null;
	}

	public override IDictionary<int, byte[]> GetClientExtensions()
	{
		return null;
	}

	public override void ProcessServerExtensions(IDictionary<int, byte[]> serverExtensions)
	{
	}

	public override TlsSrpIdentity GetSrpIdentity()
	{
		return null;
	}

	public override TlsAuthentication GetAuthentication()
	{
		return null;
	}
}
