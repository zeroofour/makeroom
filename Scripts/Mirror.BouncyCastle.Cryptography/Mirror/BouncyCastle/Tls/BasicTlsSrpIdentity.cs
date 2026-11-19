namespace Mirror.BouncyCastle.Tls;

public class BasicTlsSrpIdentity : TlsSrpIdentity
{
	protected readonly byte[] m_identity;

	protected readonly byte[] m_password;

	public BasicTlsSrpIdentity(byte[] identity, byte[] password)
	{
	}

	public BasicTlsSrpIdentity(string identity, string password)
	{
	}

	public virtual byte[] GetSrpIdentity()
	{
		return null;
	}

	public virtual byte[] GetSrpPassword()
	{
		return null;
	}
}
