using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

internal class TlsServerContextImpl : AbstractTlsContext, TlsServerContext, TlsContext
{
	public override bool IsServer => false;

	internal TlsServerContextImpl(TlsCrypto crypto)
		: base(null, 0)
	{
	}
}
