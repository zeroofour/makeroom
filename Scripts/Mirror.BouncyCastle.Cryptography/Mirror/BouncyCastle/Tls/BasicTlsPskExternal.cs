using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class BasicTlsPskExternal : TlsPskExternal, TlsPsk
{
	protected readonly byte[] m_identity;

	protected readonly TlsSecret m_key;

	protected readonly int m_prfAlgorithm;

	public virtual byte[] Identity => null;

	public virtual TlsSecret Key => null;

	public virtual int PrfAlgorithm => 0;

	public BasicTlsPskExternal(byte[] identity, TlsSecret key)
	{
	}

	public BasicTlsPskExternal(byte[] identity, TlsSecret key, int prfAlgorithm)
	{
	}
}
