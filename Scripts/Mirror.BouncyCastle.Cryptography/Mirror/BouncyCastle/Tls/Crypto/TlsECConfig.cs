namespace Mirror.BouncyCastle.Tls.Crypto;

public class TlsECConfig
{
	protected readonly int m_namedGroup;

	public virtual int NamedGroup => 0;

	public TlsECConfig(int namedGroup)
	{
	}
}
