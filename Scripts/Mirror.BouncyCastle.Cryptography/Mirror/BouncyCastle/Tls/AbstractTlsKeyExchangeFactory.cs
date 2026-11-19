using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public abstract class AbstractTlsKeyExchangeFactory : TlsKeyExchangeFactory
{
	public virtual TlsKeyExchange CreateDHKeyExchange(int keyExchange)
	{
		return null;
	}

	public virtual TlsKeyExchange CreateDHanonKeyExchangeClient(int keyExchange, TlsDHGroupVerifier dhGroupVerifier)
	{
		return null;
	}

	public virtual TlsKeyExchange CreateDHanonKeyExchangeServer(int keyExchange, TlsDHConfig dhConfig)
	{
		return null;
	}

	public virtual TlsKeyExchange CreateDheKeyExchangeClient(int keyExchange, TlsDHGroupVerifier dhGroupVerifier)
	{
		return null;
	}

	public virtual TlsKeyExchange CreateDheKeyExchangeServer(int keyExchange, TlsDHConfig dhConfig)
	{
		return null;
	}

	public virtual TlsKeyExchange CreateECDHKeyExchange(int keyExchange)
	{
		return null;
	}

	public virtual TlsKeyExchange CreateECDHanonKeyExchangeClient(int keyExchange)
	{
		return null;
	}

	public virtual TlsKeyExchange CreateECDHanonKeyExchangeServer(int keyExchange, TlsECConfig ecConfig)
	{
		return null;
	}

	public virtual TlsKeyExchange CreateECDheKeyExchangeClient(int keyExchange)
	{
		return null;
	}

	public virtual TlsKeyExchange CreateECDheKeyExchangeServer(int keyExchange, TlsECConfig ecConfig)
	{
		return null;
	}

	public virtual TlsKeyExchange CreatePskKeyExchangeClient(int keyExchange, TlsPskIdentity pskIdentity, TlsDHGroupVerifier dhGroupVerifier)
	{
		return null;
	}

	public virtual TlsKeyExchange CreatePskKeyExchangeServer(int keyExchange, TlsPskIdentityManager pskIdentityManager, TlsDHConfig dhConfig, TlsECConfig ecConfig)
	{
		return null;
	}

	public virtual TlsKeyExchange CreateRsaKeyExchange(int keyExchange)
	{
		return null;
	}

	public virtual TlsKeyExchange CreateSrpKeyExchangeClient(int keyExchange, TlsSrpIdentity srpIdentity, TlsSrpConfigVerifier srpConfigVerifier)
	{
		return null;
	}

	public virtual TlsKeyExchange CreateSrpKeyExchangeServer(int keyExchange, TlsSrpLoginParameters loginParameters)
	{
		return null;
	}
}
