using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class DefaultTlsKeyExchangeFactory : AbstractTlsKeyExchangeFactory
{
	public override TlsKeyExchange CreateDHKeyExchange(int keyExchange)
	{
		return null;
	}

	public override TlsKeyExchange CreateDHanonKeyExchangeClient(int keyExchange, TlsDHGroupVerifier dhGroupVerifier)
	{
		return null;
	}

	public override TlsKeyExchange CreateDHanonKeyExchangeServer(int keyExchange, TlsDHConfig dhConfig)
	{
		return null;
	}

	public override TlsKeyExchange CreateDheKeyExchangeClient(int keyExchange, TlsDHGroupVerifier dhGroupVerifier)
	{
		return null;
	}

	public override TlsKeyExchange CreateDheKeyExchangeServer(int keyExchange, TlsDHConfig dhConfig)
	{
		return null;
	}

	public override TlsKeyExchange CreateECDHKeyExchange(int keyExchange)
	{
		return null;
	}

	public override TlsKeyExchange CreateECDHanonKeyExchangeClient(int keyExchange)
	{
		return null;
	}

	public override TlsKeyExchange CreateECDHanonKeyExchangeServer(int keyExchange, TlsECConfig ecConfig)
	{
		return null;
	}

	public override TlsKeyExchange CreateECDheKeyExchangeClient(int keyExchange)
	{
		return null;
	}

	public override TlsKeyExchange CreateECDheKeyExchangeServer(int keyExchange, TlsECConfig ecConfig)
	{
		return null;
	}

	public override TlsKeyExchange CreatePskKeyExchangeClient(int keyExchange, TlsPskIdentity pskIdentity, TlsDHGroupVerifier dhGroupVerifier)
	{
		return null;
	}

	public override TlsKeyExchange CreatePskKeyExchangeServer(int keyExchange, TlsPskIdentityManager pskIdentityManager, TlsDHConfig dhConfig, TlsECConfig ecConfig)
	{
		return null;
	}

	public override TlsKeyExchange CreateRsaKeyExchange(int keyExchange)
	{
		return null;
	}

	public override TlsKeyExchange CreateSrpKeyExchangeClient(int keyExchange, TlsSrpIdentity srpIdentity, TlsSrpConfigVerifier srpConfigVerifier)
	{
		return null;
	}

	public override TlsKeyExchange CreateSrpKeyExchangeServer(int keyExchange, TlsSrpLoginParameters loginParameters)
	{
		return null;
	}
}
