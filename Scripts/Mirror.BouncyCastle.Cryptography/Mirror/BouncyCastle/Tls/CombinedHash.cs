using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class CombinedHash : TlsHash
{
	protected readonly TlsContext m_context;

	protected readonly TlsCrypto m_crypto;

	protected readonly TlsHash m_md5;

	protected readonly TlsHash m_sha1;

	internal CombinedHash(TlsContext context, TlsHash md5, TlsHash sha1)
	{
	}

	public CombinedHash(TlsCrypto crypto)
	{
	}

	public CombinedHash(CombinedHash t)
	{
	}

	public virtual void Update(byte[] input, int inOff, int len)
	{
	}

	public virtual byte[] CalculateHash()
	{
		return null;
	}

	public virtual TlsHash CloneHash()
	{
		return null;
	}

	public virtual void Reset()
	{
	}
}
