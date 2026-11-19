namespace Mirror.BouncyCastle.Tls;

public class BasicTlsPskIdentity : TlsPskIdentity
{
	protected readonly byte[] m_identity;

	protected readonly byte[] m_psk;

	public BasicTlsPskIdentity(byte[] identity, byte[] psk)
	{
	}

	public BasicTlsPskIdentity(string identity, byte[] psk)
	{
	}

	public virtual void SkipIdentityHint()
	{
	}

	public virtual void NotifyIdentityHint(byte[] psk_identity_hint)
	{
	}

	public virtual byte[] GetPskIdentity()
	{
		return null;
	}

	public byte[] GetPsk()
	{
		return null;
	}
}
